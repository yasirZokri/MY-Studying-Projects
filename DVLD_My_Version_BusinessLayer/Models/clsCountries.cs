using DVLD_My_Version_DataAccessLayer.Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_My_Version_BusinessLayer.Models
{
    public class clsCountries
    {
        public string CountryName { get; set; }
        public int ID { get; set; }

        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries();
        }

        public clsCountries()
        {
            // Default constructor
        }

        private clsCountries(string CountryName, int ID)
        {
            this.CountryName = CountryName;
            this.ID = ID;
        }

        public clsCountries GetCountryByName(string CountryName)
        {
            int ID = -1;
            if (clsCountriesDataAccess.GetCountryByName(CountryName, ref ID))
            {
                return new clsCountries(CountryName, ID);
            }
            else
            {
                return null; // or throw an exception if preferred
            }
        }

        public static string GetCountryByID(int ID)
        {
            return clsCountriesDataAccess.GetCountryByID(ID);
        }

    }
}
