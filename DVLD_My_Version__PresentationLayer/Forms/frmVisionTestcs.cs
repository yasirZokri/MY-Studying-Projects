using DVLD_My_Version_BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_My_Version__PresentationLayer.Forms
{
    public partial class frmVisionTestcs : Form
    {
        public frmVisionTestcs()
        {
            InitializeComponent();
            this.Height = 3400; // Very large height
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0); // Starts at top
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            _FilldgvAppointemnts();
        }






        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonInfoAsPerson frmPersonInfoAsPerson = new frmPersonInfoAsPerson();
            frmPersonInfoAsPerson.ShowDialog();
        }

        private bool CheckIfAppointemntIsBlocked()
        {
            int TestAppointmentID = clsTestAppointment.SelectTestAppoimentIDByLDLAppID(clsPeople.CurrentValue);

            if (clsTestAppointment.IsAppointmentLocked(TestAppointmentID))
            {
                return true;
            }

            return false;
        }

        private void btnAddAppointments_Click(object sender, EventArgs e)
        {
            clsTestAppointment._Mode = clsTestAppointment.enMode.Add;

            if (CheckIfAppointemntIsBlocked() == true || dgvAppointments.Rows.Count == 0)
            {
                frmScheduleVisionTest frmScheduleVisionTest = new frmScheduleVisionTest();
                frmScheduleVisionTest.ShowDialog();

            }
            else
            {
                MessageBox.Show($"You Can't Take Appointemnts {clsTestAppointment.TestTypesStrings()} Because Is Active", "Can't Take Appointemnt", MessageBoxButtons.OK);
            }
            _FilldgvAppointemnts();
        }

        private void _FilldgvAppointemnts()
        {

            dgvAppointments.DataSource = clsTestAppointment.GetAllTestAppointments(clsTestAppointment.TestTypesStrings());
        }

        private void updateAppoimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsTestAppointment._Mode = clsTestAppointment.enMode.Update;

            frmScheduleVisionTest ScheduleVisionTest = new frmScheduleVisionTest();
            ScheduleVisionTest.ShowDialog();
            _FilldgvAppointemnts();
        }

        private void deleteAppoimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TestAppointmentID = dgvAppointments.CurrentRow.Cells["TestAppointmentID"].Value; // مثلاً جاي من TextBox

            DialogResult result = MessageBox.Show(
                "هل أنت متأكد أنك تريد حذف هذا الموعد؟",
                "تأكيد الحذف",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool deleted = clsTestAppointment.DeleteTestAppointment((int)TestAppointmentID);

                if (deleted)
                    MessageBox.Show("تم حذف الموعد بنجاح ✅", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("فشل في حذف الموعد ❌", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف.", "إلغاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _FilldgvAppointemnts();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckIfAppointemntIsBlocked() == false)
            {
                frmTakeTest takeTest = new frmTakeTest();
                takeTest.ShowDialog();

            }
            else
            {
                MessageBox.Show($"Person Can't Take {clsTestAppointment.TestTypesStrings()} Because Is Blocked", "Can't Take Test", MessageBoxButtons.OK);
            }
            _FilldgvAppointemnts();

        }
    }
}
