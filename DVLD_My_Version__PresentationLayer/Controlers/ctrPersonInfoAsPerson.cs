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
    public partial class ctrPersonInfoAsPerson : UserControl
    {
        public ctrPersonInfoAsPerson()
        {
            InitializeComponent();
            _FillWithPerosnInfo();
        }

        private void _FillWithPerosnInfo()
        {

            DataTable dt = clsApplication.GetPersonInfoByApplicationID(clsPeople.CurrentValue);
            if (dt.Rows.Count > 0)
            {
                DataRow personRow = dt.Rows[0];
                lblPersonID.Text = personRow["PersonID"].ToString();
                lblFullName.Text = personRow["FirstName"].ToString() + " " + personRow["SecondName"] + " " + personRow["ThirdName"] + " " + personRow["LastName"];
                lblNationalNo.Text = personRow["NationalNo"].ToString();
                lblGendor.Text = personRow["Gendor"].ToString() == "1" ? "Male" : "Famle";
                lblEmail.Text = personRow["Email"].ToString();
                lblAddress.Text = personRow["Address"].ToString();
                lblPhone.Text = personRow["Phone"].ToString();
                lblCountry.Text = clsCountries.GetCountryByID(Convert.ToInt32(personRow["NationalityCountryID"]));
                lblDateOfBirth.Text = Convert.ToDateTime(personRow["DateOfBirth"]).ToString("yyyy-MM-dd");
                picPersonPicture.ImageLocation = personRow["ImagePath"].ToString();
            }
        }
    }
}
