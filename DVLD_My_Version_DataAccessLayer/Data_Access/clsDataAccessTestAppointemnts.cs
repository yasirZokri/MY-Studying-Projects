using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer.Data_Access
{
    public class clsDataAccessTestAppointemnts
    {

        public static DataTable GetAllTestAppointments(string TestTypesStrings, int LocalDrivingLicenseApplicationID)
        {
            DataTable dt = new DataTable();

            string query = @"
            SELECT [TestAppointmentID],
                   [LocalDrivingLicenseApplicationID],
                   [AppointmentDate],
                   [PaidFees],
                   [FullName],
                   [IsLocked]
            FROM [DVLD].[dbo].[TestAppointments_View]
            WHERE TestTypeTitle = @TestTypesStrings
            AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;

";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestTypesStrings", TestTypesStrings);
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        public static bool IsAppointmentLocked(int TestAppointmentID, string TestTypeTitle)
        {
            bool isLocked = false;

            string query = @"
            SELECT TOP 1 [IsLocked]
            FROM [DVLD].[dbo].[TestAppointments_View]
            WHERE [TestAppointmentID] = @TestAppointmentID
            AND TestTypeTitle = @TestTypeTitle";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        isLocked = Convert.ToBoolean(result);
                    }
                }
            }

            return isLocked;
        }


        public static bool AddTestAppointment(
        int testTypeID,
        int localDrivingLicenseApplicationID,
        DateTime appointmentDate,
        decimal paidFees,
        int createdByUserID,
        bool isLocked,
        int? retakeTestApplicationID)
        {
            int rowsAffected = 0;

            string query = @"
            INSERT INTO [DVLD].[dbo].[TestAppointments]
            (
                [TestTypeID],
                [LocalDrivingLicenseApplicationID],
                [AppointmentDate],
                [PaidFees],
                [CreatedByUserID],
                [IsLocked],
                [RetakeTestApplicationID]
            )
            VALUES
            (
                @TestTypeID,
                @LocalDrivingLicenseApplicationID,
                @AppointmentDate,
                @PaidFees,
                @CreatedByUserID,
                @IsLocked,
                @RetakeTestApplicationID
            )";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);
                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                cmd.Parameters.AddWithValue("@IsLocked", isLocked);
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", (object)retakeTestApplicationID ?? DBNull.Value);

                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return (rowsAffected > 0);
        }

        public static bool UpdateTestAppointment(int LocalDrivingLicenseApplicationID, DateTime newDate)
        {
            bool isUpdated = false;

            string query = @"UPDATE TestAppointments 
                     SET AppointmentDate = @NewDate 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // إضافة البراميترز
                command.Parameters.AddWithValue("@NewDate", newDate);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = (rowsAffected > 0); // صحيح إذا تم تعديل صف واحد على الأقل
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while updating TestAppointment: " + ex.Message);
                }
            }

            return isUpdated;
        }

        public static bool UpdateLockedTestAppointment(int LocalDrivingLicenseApplicationID)
        {
            bool isUpdated = false;

            string query = @"UPDATE TestAppointments 
                     SET IsLocked = 1 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // إضافة البراميترز

                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = (rowsAffected > 0); // صحيح إذا تم تعديل صف واحد على الأقل
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while updating TestAppointment: " + ex.Message);
                }
            }

            return isUpdated;
        }

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {
            bool isDeleted = false;

            string query = @"DELETE FROM TestAppointments 
                     WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    isDeleted = (rowsAffected > 0); // لو حذف صف واحد على الأقل = true
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while deleting TestAppointment: " + ex.Message);
                }
            }

            return isDeleted;
        }

        public static int SelectTestAppoimentIDByLDLAppID(int LocalDrivingLicenseApplicationID)
        {
            string Query = "SELECT TestAppointmentID FROM TestAppointments_View WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            int Result = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                try
                {
                    connection.Open();
                    object obj = command.ExecuteScalar();

                    if (obj != null && obj != DBNull.Value)
                        Result = Convert.ToInt32(obj);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in SelectTestAppoimentIDByLDLAppID: " + ex.Message);
                }
            }

            return Result;
        }


    }

}


