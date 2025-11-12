using DVLD_My_Version_BusinessLayer;
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
    public partial class frmNewLocalDrivingLicenseAppliacation : Form
    {
        public frmNewLocalDrivingLicenseAppliacation()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            _FillCommboBoxWithLicenseClassTypes();

        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUpdatePerson updatePerson = new frmUpdatePerson();
            updatePerson.ShowDialog();
        }

        private void _FillCommboBoxWithLicenseClassTypes()
        {
            DataTable dt = clsLocalDrivingLicesne.GetLienseClassTypes();
            cbLicenseClass.DataSource = dt;
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.SelectedIndex = 0;

        }

        private void _FillFeesByClassType()
        {
            if (cbLicenseClass.SelectedValue != null)
            {
                int FeesValues = cbLicenseClass.SelectedIndex;
                DataTable dt = clsLocalDrivingLicesne.GetLienseClassTypes();
                DataRow dr = dt.Rows[FeesValues];
                ApplicationFees.Text = dr["ClassFees"].ToString();
            }
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FillFeesByClassType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = clsUsers.GetUserByNameAndPassword(Properties.Settings.Default.SavedUserName, Properties.Settings.Default.SavedPassword);
            DataRow dataRow = dt.Rows[0];
            int LicenseClassType = Convert.ToInt32(cbLicenseClass.SelectedValue);
            clsApplication AddApplication = new clsApplication(
            clsPeople.CurrentValue,        // ApplicationPersonID
            DateTime.Today, // ApplicationDate
            LicenseClassType,  // ApplicationTypeID
            1,                              // ApplicationStatus (مثلاً 1 = مبدئي)
            DateTime.Today,                // LastStatusDate
            ApplicationFees.Text,          // Fees
            Convert.ToInt32(dataRow["UserID"].ToString()) // CreatedBy
);

            if (clsTests.IsTestTypeExists(clsPeople.CurrentValue, LicenseClassType))
            {

                MessageBox.Show($"Failed to Add application!, The Person has Type Of License {cbLicenseClass.Text} Before.", "Faild To Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ApplicationID.Text = AddApplication.AddApplication().ToString();
                CreatedBy.Text = dataRow["UserName"].ToString();
                ApplicatoinDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
                MessageBox.Show("Application Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
