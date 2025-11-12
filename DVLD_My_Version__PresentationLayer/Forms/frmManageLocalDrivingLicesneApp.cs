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
    public partial class frmManageLocalDrivingLicesneApp : Form
    {

        private enum enTests
        {
            None = 0,
            VisionTest = 1,
            WrittenTest = 2,
            StreatTest = 3,
        }

        private enTests TypeOfTest(int Number)
        {
            switch (Number)
            {
                case 0:
                    return enTests.None;
                case 1:
                    return enTests.VisionTest;

                case 2:
                    return enTests.WrittenTest;

                case 3:
                    return enTests.StreatTest;


                default:
                    return enTests.None;


            }
        }

        private void MakeTheMenuItemUnVisible(int Number)
        {

            switch (TypeOfTest(Number))
            {
                case enTests.None:
                    sechduleVisionTest.Enabled = true;
                    sechduleWritenTest.Enabled = false;
                    sechduleStreatTest.Enabled = false;
                    break;
                case enTests.VisionTest:
                    sechduleVisionTest.Enabled = false;
                    sechduleWritenTest.Enabled = true;
                    sechduleStreatTest.Enabled = false;
                    break;
                case enTests.WrittenTest:
                    sechduleWritenTest.Enabled = false;
                    sechduleVisionTest.Enabled = false;
                    sechduleStreatTest.Enabled = true;
                    break;
                case enTests.StreatTest:
                    sechduleVisionTest.Enabled = false;
                    sechduleWritenTest.Enabled = false;
                    sechduleStreatTest.Enabled = false;
                    break;

            }

        }

        public frmManageLocalDrivingLicesneApp()
        {
            InitializeComponent();
            _FilldgvWithLocalDrivingLicenseInfo();
            _FillcbFillterByWithColumns();
            cbFilterBy.Items.Insert(0, "None");

            txtbNumber.Visible = false;
        }

        private void _FilldgvWithLocalDrivingLicenseInfo()
        {
            dgvLocalDrivers.DataSource = clsLocalDrivingLicesne.GetAllLocalDrivingLicenseApplications();
        }

        private void _FillcbFillterByWithColumns()
        {

            DataTable dt = clsLocalDrivingLicesne.GetAllLocalDrivingLicenseApplications();
            cbFilterBy.Items.Clear();
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DataColumn dr in dt.Columns)
            {
                cbFilterBy.Items.Add(dr.ColumnName);
            }
            cbFilterBy.SelectedIndex = 0;

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex != 0)
            {
                txtbNumber.Visible = true;
            }
            else
            {
                txtbNumber.Visible = false;
            }
        }

        private void _FilldgvWithColumnNameAndRwoNumber()
        {
            dgvLocalDrivers.DataSource = clsLocalDrivingLicesne.GetFilteredApplications(cbFilterBy.SelectedItem.ToString(), txtbNumber.Text);
        }

        private void txtbNumber_TextChanged(object sender, EventArgs e)
        {
            _FilldgvWithColumnNameAndRwoNumber();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            using (frmNewLocalDrivingLicenseAppliacation newLocalDrivingLicenseAppliacation = new frmNewLocalDrivingLicenseAppliacation())
            {

                newLocalDrivingLicenseAppliacation.ShowDialog();
            }
            _FilldgvWithLocalDrivingLicenseInfo();
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void CancleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicesne.UpdateLocalDrivingLicenseApplication(Convert.ToInt32(clsPeople.CurrentValue)))
            {
                MessageBox.Show("Cancled was Successfully!", "Successed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cancled wasn't Successfully!", "Successed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _FilldgvWithLocalDrivingLicenseInfo();

        }

        private void LDLMenu_Opening(object sender, CancelEventArgs e)
        {
            clsPeople.CurrentValue = Convert.ToInt32(dgvLocalDrivers.Rows[dgvLocalDrivers.CurrentRow.Index].Cells["LDLAppID"].Value);
            MakeTheMenuItemUnVisible(Convert.ToInt32(dgvLocalDrivers.Rows[dgvLocalDrivers.CurrentRow.Index].Cells["Passed Tests"].Value));

        }

        private void sechduleVisionTest_Click(object sender, EventArgs e)
        {
            clsTestAppointment.TestsTypes = clsTestAppointment.enTestsTypes.VisionTest;
            frmVisionTestcs frmVisionTestcs = new frmVisionTestcs();
            frmVisionTestcs.ShowDialog();
            _FilldgvWithLocalDrivingLicenseInfo();
        }

        private void sechduleWritenTest_Click(object sender, EventArgs e)
        {
            clsTestAppointment.TestsTypes = clsTestAppointment.enTestsTypes.WritenTest;
            frmWrittenTest frmWrittenTest = new frmWrittenTest();
            frmWrittenTest.ShowDialog();
            _FilldgvWithLocalDrivingLicenseInfo();
        }

        private void sechduleStreatTest_Click(object sender, EventArgs e)
        {
            clsTestAppointment.TestsTypes = clsTestAppointment.enTestsTypes.StreetTest;
        }
    }
}