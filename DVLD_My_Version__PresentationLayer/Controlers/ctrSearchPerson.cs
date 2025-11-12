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

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrSearchPerson : UserControl
    {
        public ctrSearchPerson()
        {
            InitializeComponent();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsPeople.CurrentValue = Convert.ToInt32(txtSearchPerson.Text);
            _SearchPerson();
        }

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
