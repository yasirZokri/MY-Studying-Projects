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
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            _FillDataGridViewWithUsers();
            _FillComboBoxWithUserInfo();
        }

        private void _FillDataGridViewWithUsers()
        {
            dgvUsersData.DataSource = clsUsers.GetAllUsers();
        }

        private void _FillComboBoxWithUserInfo()
        {
            DataTable UsersTableColumns = clsUsers.GetAllUsers();
            cbUsersColumns.Items.Clear();
            foreach (DataColumn column in UsersTableColumns.Columns)
            {
                cbUsersColumns.Items.Add(column.ColumnName);
            }

            cbUsersColumns.Items.Insert(0, "None");
            cbUsersColumns.SelectedIndex = 0;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (frmAddUser addUser = new frmAddUser())
            {
                addUser.ShowDialog();
            }

            _FillDataGridViewWithUsers();
        }

        private void cbUsersColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSearch.Visible = cbUsersColumns.SelectedIndex != 0;
            txtSearch.Visible = cbUsersColumns.SelectedIndex != 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsersData.DataSource = clsUsers.GetByFilter(cbUsersColumns.Text, txtSearch.Text);
        }
    }
}
