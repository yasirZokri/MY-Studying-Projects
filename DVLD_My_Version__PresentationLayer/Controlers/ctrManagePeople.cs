using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_My_Version_BusinessLayer.Models;
using DVLD_My_Version__PresentationLayer.Forms;
using System.IO;

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrManagePeople : UserControl
    {
        public ctrManagePeople()
        {
            InitializeComponent();
        }

        private void ctrManagePeople_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            FillComboBoxWithPeopleInfo();
            FillDataGridViewWithPeople();
            txtbNumber.Visible = false;
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FillComboBoxWithPeopleInfo()
        {
            DataTable dt = clsPeople.GetPeople();
            cbFilterBy.Items.Clear();

            foreach (DataColumn column in dt.Columns)
            {
                cbFilterBy.Items.Add(column.ColumnName);
            }

            cbFilterBy.Items.Insert(0, "None");
            cbFilterBy.SelectedIndex = 0;
        }

        private void FillDataGridViewWithPeople()
        {
            dgPeopleData.DataSource = clsPeople.GetPeople();
            dgPeopleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbNumber.Visible = cbFilterBy.SelectedIndex != 0;
        }

        private void txtbNumber_TextChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex != 0 && !string.IsNullOrWhiteSpace(txtbNumber.Text))
            {
                dgPeopleData.DataSource = clsPeople.GetPeopleByFilter(cbFilterBy.SelectedItem.ToString(), txtbNumber.Text);
            }
            else
            {
                FillDataGridViewWithPeople();
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            clsPeople.enUpdateorAdd = clsPeople.UpdateorAdd.Add;
            ShowAddPersonForm();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            clsPeople.enUpdateorAdd = clsPeople.UpdateorAdd.Add;
            ShowAddPersonForm();
        }

        private void ShowAddPersonForm()
        {


            using (frmAddPerson frm = new frmAddPerson())
            {
                frm.ShowDialog();
            }


            FillDataGridViewWithPeople();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            clsPeople.enUpdateorAdd = clsPeople.UpdateorAdd.Update;
            clsPeople.CurrentValue = (int)dgPeopleData.CurrentRow.Cells["PersonID"].Value;
            _ShowUpdatePersonForm();
        }

        private void _ShowUpdatePersonForm()
        {
            using (frmUpdatePerson UpdatePerson = new frmUpdatePerson())
            {
                UpdatePerson.ShowDialog();
            }
            FillDataGridViewWithPeople();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgPeopleData.CurrentRow == null)
                return;

            int personID = Convert.ToInt32(dgPeopleData.CurrentRow.Cells["PersonID"].Value);
            string imagePath = clsPeople.GetPersonImagePathByID(personID);

            DialogResult result = MessageBox.Show("هل تريد حذف هذا السجل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            bool deleted = clsPeople.Delete(personID);

            if (deleted)
            {
                // حذف الصورة إذا كانت موجودة
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        File.Delete(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("تم حذف السجل ولكن فشل حذف الصورة:\n" + ex.Message, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                MessageBox.Show("تم الحذف بنجاح ✅", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridViewWithPeople();
            }
            else
            {
                MessageBox.Show("فشل في الحذف ❌", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
