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
    public partial class frmUpdateTestTypes : Form
    {
        public frmUpdateTestTypes()
        {
            InitializeComponent();
        }

        private int _ID = 0;

        public frmUpdateTestTypes(int ID)
        {
            InitializeComponent();
            _ID = ID;

            TestID.Text = ID.ToString();
        }

        private void _UpdateTestTypes(int ID)
        {
            if (clsTests.Update(ID, txtTitle.Text, txtDescription.Text, Convert.ToInt32(txtFees.Text)))
            {
                MessageBox.Show("✔ تم التحديث بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ فشل التحديث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _UpdateTestTypes(_ID);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Close The Form?", "Colse The Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
