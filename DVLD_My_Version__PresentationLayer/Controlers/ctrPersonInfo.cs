using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_My_Version_BusinessLayer;
using DVLD_My_Version_BusinessLayer.Models;

namespace DVLD_My_Version__PresentationLayer.Controlers
{
    public partial class ctrPersonInfo : UserControl
    {
        private string CurrentUserName;
        private string CurrentUserPassword;
        private DataTable _UserInfo;
        private int _PersonID;

        public ctrPersonInfo()
        {
            InitializeComponent();
            CurrentUserName = Properties.Settings.Default.SavedUserName;
            CurrentUserPassword = Properties.Settings.Default.SavedPassword;
            _UserInfo = clsUsers.GetUserByNameAndPassword(CurrentUserName, CurrentUserPassword);
            _GetUserInfo();
        }

        private void _GetUserInfo()
        {
            if (_UserInfo.Rows.Count > 0)
            {
                DataRow row = _UserInfo.Rows[0];
                _PersonID = Convert.ToInt32(row["PersonID"]);
                lblPersonID.Text = _PersonID.ToString();
                lblUserID.Text = row["UserID"].ToString();
                lblUserName.Text = row["UserName"].ToString();
                lblIsActive.Text = row["IsActive"].ToString() == "true" ? "Active" : "Not Active";

                DataTable dt = clsPeople.GetPersonByID(_PersonID);
                if (dt.Rows.Count > 0)
                {
                    DataRow personRow = dt.Rows[0];
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
}
