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
    public partial class frmManageTestTypes : Form
    {
        public frmManageTestTypes()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeComponent();
            _FilldgvWithTestTypes();
        }

        private void _FilldgvWithTestTypes()
        {
            dgvTestTypes.DataSource = clsTests.GetAllTestTypes();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int selectedIndex = dgvTestTypes.CurrentCell.RowIndex;
            int TestIDCell = Convert.ToInt32(dgvTestTypes.Rows[selectedIndex].Cells["TestTypeID"].Value);

            frmUpdateTestTypes updateTestTypes = new frmUpdateTestTypes(TestIDCell);
            updateTestTypes.ShowDialog();
            _FilldgvWithTestTypes();

        }
    }
}

//if (dgvTestTypes.CurrentRow != null)
//{
//    try
//    {
//        int id = Convert.ToInt32(dgvTestTypes.CurrentRow.Cells["TestTypeID"].Value);
//        string title = dgvTestTypes.CurrentRow.Cells["TestTypeTitle"].Value?.ToString();
//        string description = dgvTestTypes.CurrentRow.Cells["TestTypeDescription"].Value?.ToString();
//        decimal fees = Convert.ToDecimal(dgvTestTypes.CurrentRow.Cells["TestTypeFees"].Value);

//        if (clsTestTypes.Update(id, title, description, fees))
//        {
//            MessageBox.Show("✔ تم التحديث بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }
//        else
//        {
//            MessageBox.Show("❌ فشل التحديث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show("⚠ حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}