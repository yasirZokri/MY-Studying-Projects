using DVLD_My_Version_DataAccessLayer.Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DVLD_My_Version_DataAccessLayer.Data_Access.clsDataAccessApplication;
using static DVLD_My_Version_DataAccessLayer.Data_Access.clsDataAccessTestAppointemnts;

namespace DVLD_My_Version_BusinessLayer.Models
{
    public class clsTestAppointment
    {

        public enum enTestsTypes
        {
            VisionTest = 1,
            WritenTest = 2,
            StreetTest = 3,
        };

        public enum enMode
        {
            Add = 0,
            Update = 1
        };

        public static enMode _Mode = enMode.Add;


        public int TestTypeID { get; set; }                  // نوع الاختبار
        public int LocalDrivingLicenseApplicationID { get; set; } // رقم الطلب
        public DateTime AppointmentDate { get; set; }        // تاريخ الموعد
        public decimal PaidFees { get; set; }                // الرسوم
        public int CreatedByUserID { get; set; }             // أنشأ بواسطة
        public bool IsLocked { get; set; }                   // حالة القفل
        public int? RetakeTestApplicationID { get; set; }    // رقم طلب إعادة الاختبار (قد يكون NULL)

        public bool Save()
        {
            return clsDataAccessTestAppointemnts.AddTestAppointment(
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,
                this.PaidFees,
                this.CreatedByUserID,
                this.IsLocked,
                this.RetakeTestApplicationID
            );
        }

        public static enTestsTypes TestsTypes = enTestsTypes.VisionTest;

        public static string TestTypesStrings()
        {
            if (TestsTypes == enTestsTypes.VisionTest)
            {
                return "Vision Test";
            }
            else if (TestsTypes == enTestsTypes.WritenTest)
            {
                return "written";
            }
            else if (TestsTypes == enTestsTypes.StreetTest)
            {
                return "Practical (Street) Test";
            }

            return "";


        }

        public static DataTable GetAllTestAppointments(string TestTypesStrings)
        {
            return clsDataAccessTestAppointemnts.GetAllTestAppointments(TestTypesStrings, clsPeople.CurrentValue);
        }

        public static bool IsAppointmentLocked(int TestAppointmentID)
        {
            return clsDataAccessTestAppointemnts.IsAppointmentLocked(TestAppointmentID, TestTypesStrings());
        }



        public bool UpdateTestAppointmentDate()
        {
            return clsDataAccessTestAppointemnts.UpdateTestAppointment(LocalDrivingLicenseApplicationID, AppointmentDate);
        }

        public static bool DeleteTestAppointment(int appointmentID)
        {
            return clsDataAccessTestAppointemnts.DeleteTestAppointment(appointmentID);
        }

        public static DateTime? GetAppointmentDate(int LocalDrivingLicenseApplicationID)
        {
            return clsTestAppointmentsData.GetAppointmentDateByID(LocalDrivingLicenseApplicationID);
        }

        public static int SelectTestAppoimentIDByLDLAppID(int appointmentID)
        {
            return clsDataAccessTestAppointemnts.SelectTestAppoimentIDByLDLAppID(appointmentID);
        }

        public static bool UpdateLockedTestAppointment(int LocalDrivingLicenseApplicationID)
        {
            return clsDataAccessTestAppointemnts.UpdateLockedTestAppointment(LocalDrivingLicenseApplicationID);
        }

    }
}
