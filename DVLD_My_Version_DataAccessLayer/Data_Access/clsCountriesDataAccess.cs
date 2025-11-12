using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_My_Version_DataAccessLayer.Data_Access
{
    public static class clsCountriesDataAccess
    {
        public static DataTable GetAllCountries()
        {
            DataTable AllCountries = new DataTable();
            string connectionString = clsDataAccessSettings.DataBaseInfos;
            string query = "SELECT * FROM Countries";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            AllCountries.Load(reader);
                        }
                        else
                        {
                            AllCountries = new DataTable(); // Return an empty DataTable if no rows found
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return AllCountries;
        }

        public static bool GetCountryByName(string countryName, ref int ID)
        {
            string connectionString = clsDataAccessSettings.DataBaseInfos;
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryName", countryName);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ID = (int)reader["CountryID"];
                            }
                        }

                        return true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }

            return false;

        }

        public static string GetCountryByID(int countryID)
        {
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            string CountryName = "";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CountryID", countryID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CountryName = reader["CountryName"].ToString();

                        }

                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
            return CountryName;
        }
    }
}