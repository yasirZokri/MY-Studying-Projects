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
    public partial class frmScheduleVisionTest : Form
    {
        public frmScheduleVisionTest()
        {
            InitializeComponent();
            this.Height = 3400; // Very large height
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0); // Starts at top
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btntSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want Close The Vision Test Form?", "Close From Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
