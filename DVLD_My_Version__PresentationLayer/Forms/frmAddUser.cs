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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            _FillComboBoxWithPeopleColumn();
        }

        private void _FillComboBoxWithPeopleColumn()
        {
            DataTable dt = clsPeople.GetPeople();
            cbPeopleColumns.Items.Clear();
            foreach (DataColumn PeopleColumns in dt.Columns)
            {
                cbPeopleColumns.Items.Add(PeopleColumns.ColumnName);
            }

            cbPeopleColumns.DropDownStyle = ComboBoxStyle.DropDownList;

            cbPeopleColumns.SelectedText = "PersonID";
            cbPeopleColumns.SelectedIndex = 0;

        }

        private void _SearchPerson()
        {
            string ComboBoxText = cbPeopleColumns.Text;
            string SearchPersonText = txtSearchPerson.Text;
            DataTable dt = clsPeople.GetPeopleByFilter(ComboBoxText, SearchPersonText);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int GendorOfPerson = Convert.ToInt32(row["Gendor"]);
                string imagePath = row["ImagePath"].ToString();
                PersonID.Text = row["PersonID"].ToString();
                PersonName.Text = row["FirstName"].ToString() + " " +
                                  row["SecondName"].ToString() + " " +
                                  row["ThirdName"].ToString() + " " +
                                  row["LastName"].ToString();

                NationalNo.Text = row["NationalNo"].ToString();
                Address.Text = row["Address"].ToString();
                Phone.Text = row["Phone"].ToString();
                Email.Text = row["Email"].ToString();
                Gendor.Text = GendorOfPerson == 0 ? "Man" : "Fmale";
                Country.Text = clsCountries.GetCountryByID(Convert.ToInt32(row["NationalityCountryID"]));
                DateOfBirht.Text = Convert.ToDateTime(row["DateOfBirth"]).ToString("yyyy-MM-dd");
                Picture.ImageLocation = string.IsNullOrEmpty(imagePath) ? null : imagePath;
            }
            else
            {
                return;
            }
        }

        private bool _AddNewUser()
        {
            int isCheckBoxActive = isActive.Checked ? 1 : 0;
            clsUsers User = new clsUsers(Convert.ToInt32(PersonID.Text), txtUserName.Text, txtPassword.Text, isCheckBoxActive);

            return User.AddUser();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchPerson();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcFindUserInfoAndConectedWithPerson.SelectedTab = pgAddUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Your Sure to Close This Form?", "Caution", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (_AddNewUser())
            {
                lblPersonID.Text = PersonID.Text;
                MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();



            }
            else
            {
                MessageBox.Show("Error Adding User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }

}
