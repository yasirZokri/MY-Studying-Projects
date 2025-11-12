using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_My_Version__PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LogInPage loginpage = new LogInPage();
            loginpage.StartPosition = FormStartPosition.CenterScreen;
            loginpage.ShowInTaskbar = true;
            loginpage.WindowState = FormWindowState.Normal;
            Application.Run(loginpage);

        }
    }
}
