using DVLD_My_Version_DataAccessLayer.Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DVLD_My_Version_DataAccessLayer.Data_Access.clsDataAccessLocalDrivingLicesne;

namespace DVLD_My_Version_BusinessLayer.Models
{
    public class clsLocalDrivingLicesne
    {

        public static DataTable GetLienseClassTypes()
        {
            return clsDataAccessLocalDrivingLicesne.LicenseClassTypes();
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsDataAccessLocalDrivingLicesne.GetAllLocalDrivingLicenseApplications();
        }


        public static DataTable GetFilteredApplications(string columnName, string value)
        {
            return clsDataAccessLocalDrivingLicesne.GetFilteredApplications(columnName, value);
        }

        public static bool UpdateLocalDrivingLicenseApplication(int ID)
        {
            return clsDataAccessLocalDrivingLicesne.UpdateLocalDrivingLicenseApplication(ID);
        }
    }
}
