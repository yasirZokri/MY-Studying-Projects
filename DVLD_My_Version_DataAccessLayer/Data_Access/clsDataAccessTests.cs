using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer.Data_Access
{
    public class clsDataAccessTests
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                string query = "SELECT * FROM TestTypes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        public static bool UpdateTestType(int testTypeID, string title, string description, decimal fees)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                string query = @"UPDATE TestTypes 
                         SET TestTypeTitle = @Title, 
                             TestTypeDescription = @Description, 
                             TestTypeFees = @Fees 
                         WHERE TestTypeID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Fees", fees);
                    command.Parameters.AddWithValue("@ID", testTypeID);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public static int CheckIsLocked(int AppID)
        {
            int lockedCount = 0;

            string query = @"SELECT COUNT(*) AS IsLockedOrNot
                     FROM TestAppointments_View
                     WHERE LocalDrivingLicenseApplicationID = @AppID 
                     AND IsLocked = 1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppID", AppID);

                    connection.Open();
                    lockedCount = (int)command.ExecuteScalar();
                }
            }

            return lockedCount;
        }

        public static int GetTestTypeIDFromName(string TestTypeTitle)
        {
            DataTable dt = new DataTable();
            int testTypeID = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                string query = "SELECT TestTypeID FROM TestTypes WHERE TestTypeTitle = @TestTypeTitle";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                    connection.Open();

                    object Result = command.ExecuteScalar();
                    if (Result != null && Result != DBNull.Value)
                    {
                        testTypeID = Convert.ToInt32(Result);
                    }
                }
            }

            return testTypeID;
        }

        public static int AddNewTest(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            int newTestID = -1;

            string query = @"
        INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
        VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
        SELECT SCOPE_IDENTITY();";   // يرجع TestID الجديد

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                command.Parameters.AddWithValue("@TestResult", testResult);
                command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        newTestID = Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in AddNewTest: " + ex.Message);
                }
            }

            return newTestID;
        }

        public static bool GetTestResult(int testAppointmentID, string TestTypeTitle)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                string query = @"
            SELECT TestResult
            FROM APPOINTMENT_VIEW
            WHERE TestAppointmentID = @TestAppointmentID
              AND TestTypeTitle = @TestTypeTitle;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);

                    connection.Open();
                    object obj = command.ExecuteScalar();

                    if (obj != null && obj != DBNull.Value)
                    {
                        result = Convert.ToBoolean(obj);
                    }
                }
            }

            return result;
        }



    }
}
