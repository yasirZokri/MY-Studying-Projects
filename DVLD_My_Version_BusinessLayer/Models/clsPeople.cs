using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_My_Version_DataAccessLayer.Data_Access;

namespace DVLD_My_Version_BusinessLayer.Models
{
    public class clsPeople
    {
        public enum Gendor { Male = 0, Female = 1 }
        public enum UpdateorAdd { Add = 1, Update = 2 }


        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gendor enGendor { get; set; }

        public static UpdateorAdd enUpdateorAdd { get; set; }

        public static int CurrentValue { get; set; }

        public static bool IsAdd()
        {
            return enUpdateorAdd == UpdateorAdd.Add;
        }

        public int Add()
        {

            return clsPeopleDataAccess.AddNewPerson(
               this.NationalNumber,
               this.FirstName,
               this.SecondName,
               this.ThirdName,
               this.LastName,
               this.Address,
               (int)this.enGendor,
               this.PhoneNumber,
               this.Email,
               this.NationalityCountryID,
               this.ImagePath,
               this.DateOfBirth
           );
        }

        public static DataTable GetPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        public static DataTable GetPersonByID(int id)
        {
            return clsPeopleDataAccess.GetPersonByID(id);
        }

        public static bool ExistsByNationalNo(string nationalNo)
        {
            return clsPeopleDataAccess.IsNationalNumberExist(nationalNo);
        }

        public static bool Delete(int id)
        {
            return clsPeopleDataAccess.DeletePersonByID(id);
        }

        public bool Update()
        {
            return clsPeopleDataAccess.UpdatePerson(
                this.PersonID,
                this.NationalNumber,
                this.FirstName,
                this.SecondName,
                this.ThirdName,
                this.LastName,
                this.Address,
                (int)this.enGendor,
                this.PhoneNumber,
                this.Email,
                this.NationalityCountryID,
                this.ImagePath,
                this.DateOfBirth
            );
        }


        public static DataTable GetPeopleByFilter(string column, string value)
        {
            return clsPeopleDataAccess.GetPeopleByFilter(column, value);
        }

        public static string GetPersonImagePathByID(int ID)
        {
            return clsPeopleDataAccess.GetPersonImagePathByID(ID);
        }
    }
}

