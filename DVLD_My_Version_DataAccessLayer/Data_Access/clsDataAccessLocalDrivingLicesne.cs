using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer.Data_Access
{
    public class clsDataAccessLocalDrivingLicesne
    {

        public static DataTable LicenseClassTypes()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM LicenseClasses";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        dt.Load(reader);
                    }
                }
            }

            return dt;

        }

        public static bool IsPersonHasClassLicense(int ID, int LicenseClassType)
        {
            string query = "SELECT * FROM Applications WHERE ApplicantPersonID = @ID AND ApplicationStatus != 2 AND ApplicationTypeID = @LicenseClassType";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@LicenseClassType", LicenseClassType);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            // تعديل اسم الاتصال حسب المشروع
            string connectionString = clsDataAccessSettings.DataBaseInfos;
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM LocalDrivingLicenseApplication_View";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        // هنا ممكن تخزن الاستثناء في ملف لوق أو تعرض رسالة
                        throw new Exception("Error loading LocalDrivingLicenseApplication_View", ex);
                    }
                }
            }

            return dt;
        }


        public static DataTable GetFilteredApplications(string columnName, string value)
        {
            DataTable dt = new DataTable();

            string query = $"SELECT * FROM LocalDrivingLicenseApplication_View WHERE [{columnName}] LIKE @Value";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static bool AddLocalDrivingLicenseApplication(int applicationID, int LicenseClassID)
        {
            bool isAdded = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                         VALUES (@ApplicationID, @LicenseClassID)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", applicationID);
                command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                try
                {
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    isAdded = (rowsAffected > 0);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding new LocalDrivingLicenseApplication.", ex);
                }
            }

            return isAdded;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int applicationID)
        {
            string Query = "UPDATE A\r\nSET A.ApplicationStatus = 2\r\nFROM Applications A \r\nINNER JOIN LocalDrivingLicenseApplications L\r\nON A.ApplicationID = L.ApplicationID\r\nWHERE L.LocalDrivingLicenseApplicationID = @applicationID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@applicationID", applicationID);
                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }

        }
    }
}

