using DVLD_My_Version_DataAccessLayer.Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_BusinessLayer.Models
{
    public class clsApplication
    {

        private int _ApplicationPersonID { get; set; }
        private DateTime _ApplictaionDate { get; set; }
        private int _AplicationTypeID { get; set; }
        private int _ApplicationStatus { get; set; }
        private DateTime _LastStatusDate { get; set; }
        private string _Fees { get; set; }
        private int _CreatedBy { get; set; }

        public clsApplication(int ApplicationPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, string Fees, int CreatedBy)
        {

            _ApplicationPersonID = ApplicationPersonID;
            _ApplictaionDate = ApplicationDate;
            _AplicationTypeID = ApplicationTypeID;
            _ApplicationStatus = ApplicationStatus;
            _LastStatusDate = LastStatusDate;
            _Fees = Fees;
            _CreatedBy = CreatedBy;
        }

        public int AddApplication()
        {
            int applicationID = clsDataAccessApplication.AddApplication(
    _ApplicationPersonID,
    _ApplictaionDate,
    _AplicationTypeID,
    _ApplicationStatus,
    _LastStatusDate,
    _Fees,
    _CreatedBy
);

            if (applicationID == -1)
                return -1;

            bool isLocalAdded = clsDataAccessLocalDrivingLicesne.AddLocalDrivingLicenseApplication(applicationID, _AplicationTypeID);

            return isLocalAdded ? applicationID : -1;

        }

        public static DataTable GetApplications()
        {
            return clsDataAccessApplication.GetApplications();
        }

        public static DataTable GetPersonInfoByApplicationID(int applicationID)
        {
            return clsDataAccessApplication.GetPersonInfoByApplicationID(applicationID);
        }

        public static void UpdateApplicationStatus(int localDrivingLicenseApplicationID, int applicationStatus)
        {
            clsDataAccessApplication.UpdateApplicationStatus(localDrivingLicenseApplicationID, applicationStatus);
        }

    }
}
