using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace DVLDAppPL
{
    public partial class frmMainPage : MaterialForm
    {
        public frmMainPage()
        {
            InitializeComponent();
            this.Text = "";

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ManagePeople managePeopleForm = new ManagePeople())
            {
                managePeopleForm.ShowDialog();
            }
        }
    }
}
