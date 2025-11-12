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
using System.Xml.Linq;

namespace DVLD_My_Version__PresentationLayer
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            txtbox_username.Text = Properties.Settings.Default.SavedUserName;
            txtbox_password.Text = Properties.Settings.Default.SavedPassword;
            chbox_rememberMe.Checked = !string.IsNullOrEmpty(Properties.Settings.Default.SavedUserName);

        }



        private void button1_Click(object sender, EventArgs e)
        {

            string username = txtbox_username.Text;
            string password = txtbox_password.Text;

            if (clsUsers.CheckUserNameAndPassowrd(username, password))
            {
                if (chbox_rememberMe.Checked)
                {
                    Properties.Settings.Default.SavedUserName = username;
                    Properties.Settings.Default.SavedPassword = password;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.SavedUserName = string.Empty;
                    Properties.Settings.Default.SavedPassword = string.Empty;
                    Properties.Settings.Default.Save();

                }

                this.Hide(); // يخفي صفحة الدخول
                frMainPage mainPage = new frMainPage();
                mainPage.ShowDialog(); // يوقف الكود هنا حتى يتم إغلاق MainPage
                this.Close(); // يُغلق LoginPage نهائيًا بعد الخروج من MainPage

            }
            else
            {
                MessageBox.Show("Your UserName Or Password Was Wrong!", "SomeThing was Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_username.Text = string.Empty;
                txtbox_password.Text = string.Empty;
            }
        }
    }
}
