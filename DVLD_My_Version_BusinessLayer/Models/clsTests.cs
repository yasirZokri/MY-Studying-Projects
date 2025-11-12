using DVLD_My_Version_DataAccessLayer.Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_BusinessLayer.Models
{
    public class clsTests
    {

        private int TestAppointmentID { get; set; }
        private bool TestResult { get; set; }
        private string Note { get; set; }
        private int CreatedByUserID { get; set; }

        // Constructor
        public clsTests(int testAppointmentID, bool testResult, string note, int createdByUserID)
        {
            this.TestAppointmentID = testAppointmentID;
            this.TestResult = testResult;
            this.Note = note;
            this.CreatedByUserID = createdByUserID;
        }



        public static DataTable GetAllTestTypes()
        {
            return clsDataAccessTests.GetAllTestTypes();
        }

        public static bool Update(int testTypeID, string title, string description, decimal fees)
        {
            return clsDataAccessTests.UpdateTestType(testTypeID, title, description, fees);
        }

        public static bool IsTestTypeExists(int ID, int LicenseClassType)
        {
            return clsDataAccessLocalDrivingLicesne.IsPersonHasClassLicense(ID, LicenseClassType);
        }

        public static int CheckIsLocked(int AppID)
        {
            return clsDataAccessTests.CheckIsLocked(AppID);
        }

        public static int GetTestTypeIDFromName(string name)
        {
            return clsDataAccessTests.GetTestTypeIDFromName(name);
        }

        public int CreateNewTest()
        {
            return clsDataAccessTests.AddNewTest(
                this.TestAppointmentID,
                this.TestResult,
                this.Note,
                this.CreatedByUserID
            );
        }

        public static bool GetTestResult(int testAppointmentID, string TestTitle)
        {
            return clsDataAccessTests.GetTestResult(testAppointmentID, TestTitle);
        }


    }
}

