using DVLD_My_Version_BusinessLayer;
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
    public partial class frmChangeUserPassword : Form
    {
        public frmChangeUserPassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != Properties.Settings.Default.SavedPassword)
                errorProvider1.SetError(txtCurrentPassword, "Wrong");
            else
                errorProvider1.SetError(txtCurrentPassword, string.Empty);
        }

        private void btnSaveNewUserPassword_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == Properties.Settings.Default.SavedPassword && txtNewPassword.Text == txtNewPasswordAgain.Text)
            {
                if (clsUsers.UpdateUser(Properties.Settings.Default.SavedUserName, txtNewPasswordAgain.Text))
                    if (MessageBox.Show("Saved New Password", "Saved!", MessageBoxButtons.OK) == DialogResult.OK)
                        this.Close();

            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Close?", "Close Form Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}