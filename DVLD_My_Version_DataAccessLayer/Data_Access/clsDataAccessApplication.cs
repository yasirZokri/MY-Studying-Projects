using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_DataAccessLayer.Data_Access
{
    public class clsDataAccessApplication
    {
        public static int AddApplication(
     int applicantPersonID,
     DateTime applicationDate,
     int applicationTypeID,
     int applicationStatus,
     DateTime lastStatusDate,
     string fees,
     int createdBy)
        {
            string query = @"
INSERT INTO Applications 
(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
VALUES 
(@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
SELECT SCOPE_IDENTITY();
";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                command.Parameters.AddWithValue("@PaidFees", fees);
                command.Parameters.AddWithValue("@CreatedByUserID", createdBy);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int generatedID))
                {
                    return generatedID;
                }

                return -1; // فشل الإضافة
            }
        }

        public static DataTable GetApplications()
        {
            const string query = @"
        SELECT 
            a.ApplicationID,
            a.ApplicantPersonID,
            a.ApplicationStatus,
            a.ApplicationTypeID,
            a.ApplicationDate,
            a.PaidFees,
            a.CreatedByUserID,
            l.LocalDrivingLicenseApplicationID,
            v.[Driving Class],
            v.NationalNo,
            v.[FULL Name],
            v.Status,
            v.[Passed Tests]
        FROM Applications a
        INNER JOIN LocalDrivingLicenseApplications l
            ON a.ApplicationID = l.ApplicationID
        INNER JOIN LocalDrivingLicenseApplication_View v
            ON l.LocalDrivingLicenseApplicationID = v.LDLAppID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                connection.Open();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetPersonInfoByApplicationID(int applicationId)
        {
            const string query = @"
SELECT 
    p.PersonID,
    p.NationalNo,
    p.FirstName,
    p.SecondName,
    p.ThirdName,
    p.LastName,
    p.DateOfBirth,
    p.Gendor,
    p.Address,
    p.Phone,
    p.Email,
    p.NationalityCountryID,
    p.ImagePath,
    v.[Passed Tests],
    v.LDLAppID,
    v.[Driving Class],
v.[FULL Name],
    a.PaidFees
FROM LocalDrivingLIcenseApplication_View v
INNER JOIN People p
    ON v.NationalNo = p.NationalNo
INNER JOIN LocalDrivingLicenseApplications l
    ON v.LDLAppID = l.LocalDrivingLicenseApplicationID
INNER JOIN Applications a
    ON l.ApplicationID = a.ApplicationID
WHERE v.LDLAppID = @ApplicationID";


            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = applicationId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }


        }

        public static class clsTestAppointmentsData
        {
            public static DateTime? GetAppointmentDateByID(int LocalDrivingLicenseApplicationID)
            {
                DateTime? appointmentDate = null;

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
                {
                    string query = "SELECT AppointmentDate FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        try
                        {
                            connection.Open();
                            object result = command.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                            {
                                appointmentDate = Convert.ToDateTime(result);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error in DAL: " + ex.Message);
                        }
                    }
                }

                return appointmentDate;
            }


        }

        public static void UpdateApplicationStatus(int localDrivingLicenseApplicationID, int applicationStatus)
        {
            string query = @"UPDATE A
SET A.ApplicationStatus = @ApplicationStatus
FROM Applications A
INNER JOIN LocalDrivingLicenseApplications L
    ON A.ApplicationID = L.ApplicationID
WHERE L.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;
";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.DataBaseInfos))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


    }


}

