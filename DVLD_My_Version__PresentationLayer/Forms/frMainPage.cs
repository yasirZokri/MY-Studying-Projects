using DVLD_My_Version__PresentationLayer;
using DVLD_My_Version__PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLD_My_Version__PresentationLayer
{
    public partial class frMainPage : Form
    {
        public frMainPage()
        {
            InitializeComponent();
        }

        private LogInPage loginForm;

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frManagePeople managePeople = new frManagePeople();
            managePeople.ShowDialog();
        }

        private void frMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUser users = new frmManageUser();
            users.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrentUserInfo frmCurrentUserInfo = new frmCurrentUserInfo();
            frmCurrentUserInfo.Show();
        }

        private void changeUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frmChangeUserPassword = new frmChangeUserPassword();
            frmChangeUserPassword.ShowDialog();
        }

        private void replaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalDrivingLicenseAppliacation frmNewLocalDrivingLicenseAppliacation = new frmNewLocalDrivingLicenseAppliacation();
            frmNewLocalDrivingLicenseAppliacation.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            loginForm.Show();
            this.Close(); // أو Close() إذا لم يكن هذا هو الفورم الأساسي في Application.Run()



        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationTypes frmManageApplicationTypes = new frmManageApplicationTypes();
            frmManageApplicationTypes.ShowDialog();
        }

        private void ManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frmManageTestTypes = new frmManageTestTypes();
            frmManageTestTypes.Show();
        }

        private void manageLocalDriverLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicesneApp frmManageLocalDrivingLicesneApp = new frmManageLocalDrivingLicesneApp();
            frmManageLocalDrivingLicesneApp.Show();
        }
    }
}
