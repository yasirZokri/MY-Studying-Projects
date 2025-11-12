using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer
{
    public class clsUserDataAccess
    {
        public static bool CheckUserNameAndPassword(string Username, string Password)
        {
            string Query = "SELECT * FROM Users WHERE UserName = @Username AND Password = @Password  AND IsActive LIKE 1";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // يوجد مستخدم بالمعلومات
                            return true;
                        }
                        else
                        {
                            // لا يوجد مستخدم بهذه المعلومات
                            return false;
                        }
                    }
                }
            }
        }


        public static DataTable GetAllUsers()
        {
            string connectionString = clsDataAccessSettings.DataBaseInfos;
            string query = "SELECT * FROM Users"; // تأكد من اسم الجدول الصحيح

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dtUsers = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dtUsers);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                return dtUsers;
            }
        }

        public static DataTable GetUsersByFilter(string columnName, string value)
        {
            string query = $"SELECT * FROM Users WHERE {columnName} LIKE @value + '%'";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@value", value);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        public bool AddUser(int PersonID, string userName, string password, int isActive)
        {
            string query = @"
INSERT INTO Users (PersonID, UserName, Password, IsActive)
VALUES (@PersonID, @UserName, @Password, @IsActive)
SELECT SCOPE_IDENTITY()
";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@IsActive", isActive);

                connection.Open();
                int result = command.ExecuteNonQuery();

                return result > 0;
            }
        }

        public static DataTable GetUserByNameAndPassword(string Name, string Password)
        {
            string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserName", Name);
                command.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public static bool UpdateUser(string UserName, string Password)
        {
            string query = "UPDATE Users SET Password = @Password WHERE UserName = @UserName";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@UserName", UserName);
                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public static int GetUserIDFromLogin(string userName, string password)
        {
            int userID = -1; // قيمة افتراضية في حال ما لقينا مستخدم

            string connectionString = clsDataAccessSettings.DataBaseInfos;
            string query = "SELECT UserID FROM Users WHERE UserName = @UserName AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // إضافة البراميترز
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar(); // ترجع أول قيمة من أول صف

                    if (result != null && result != DBNull.Value)
                    {
                        userID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return userID;
        }


    }

}
