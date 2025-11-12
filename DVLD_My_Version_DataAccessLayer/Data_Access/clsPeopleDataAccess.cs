using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer.Data_Access
{
    public class clsPeopleDataAccess
    {
        public static string GetPersonImagePathByID(int personID)
        {
            string imagePath = null;

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                SqlCommand cmd = new SqlCommand("SELECT ImagePath FROM People WHERE PersonID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", personID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    imagePath = reader["ImagePath"].ToString();
                }
            }

            return imagePath;
        }


        public static DataTable GetAllPeople()
        {
            string query = "SELECT * FROM People";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetPersonByID(int personID)
        {
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }

        public static int AddNewPerson(
       string nationalNumber,
       string firstName,
       string secondName,
       string thirdName,
       string lastName,
       string address,
       int gender,
       string phoneNumber,
       string email,
       int nationalityCountryID,
       string imagePath,
       DateTime dateOfBirth)
        {
            string query = @"
INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, Address, Gendor, Phone, Email, NationalityCountryID, ImagePath, DateOfBirth)
VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @Address, @Gendor, @Phone, @Email, @NationalityCountryID, @ImagePath, @DateOfBirth);
SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NationalNo", nationalNumber);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@SecondName", secondName);
                command.Parameters.AddWithValue("@ThirdName", thirdName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Gendor", gender);
                command.Parameters.AddWithValue("@Phone", phoneNumber);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
                command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imagePath) ? DBNull.Value : (object)imagePath);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static bool UpdatePerson(
       int personID,
       string nationalNumber,
       string firstName,
       string secondName,
       string thirdName,
       string lastName,
       string address,
       int gender,
       string phoneNumber,
       string email,
       int nationalityCountryID,
       string imagePath,
       DateTime dateOfBirth)
        {
            string query = @"
UPDATE People
SET NationalNo = @NationalNo,
    FirstName = @FirstName,
    SecondName = @SecondName,
    ThirdName = @ThirdName,
    LastName = @LastName,
    Address = @Address,
    Gendor = @Gendor,
    Phone = @Phone,
    Email = @Email,
    NationalityCountryID = @NationalityCountryID,
    ImagePath = @ImagePath,
    DateOfBirth = @DateOfBirth
WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@NationalNo", nationalNumber);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@SecondName", secondName);
                command.Parameters.AddWithValue("@ThirdName", thirdName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Gendor", gender);
                command.Parameters.AddWithValue("@Phone", phoneNumber);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
                command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imagePath) ? DBNull.Value : (object)imagePath);
                command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool IsNationalNumberExist(string nationalNo)
        {
            string query = "SELECT COUNT(*) FROM People WHERE NationalNo = @NationalNo";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NationalNo", nationalNo);
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }

        public static DataTable GetPeopleByFilter(string columnName, string value)
        {
            string query = $"SELECT * FROM People WHERE {columnName} LIKE @value";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@value", value + "%"); // 🔥 الحل هنا
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        int s = dt.Rows.Count;
                        return dt;
                    }
                }
            }
        }


        public static bool DeletePersonByID(int personID)
        {
            string query = "DELETE FROM People WHERE PersonID = @PersonID";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
