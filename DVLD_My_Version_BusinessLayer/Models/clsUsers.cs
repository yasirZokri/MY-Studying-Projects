using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLD_My_Version_DataAccessLayer;

namespace DVLD_My_Version_BusinessLayer
{
    public class clsUsers
    {

        private int _PersonID { get; set; }
        private string _UserName { get; set; }
        private string _Password { get; set; }
        private int _IsActive { get; set; }

        public clsUsers(int PersonID, string UserName, string Password, int IsActive)
        {
            _PersonID = PersonID;
            _UserName = UserName;
            _Password = Password;
            _IsActive = IsActive;
        }

        public static bool CheckUserNameAndPassowrd(string Username, string Password)
        {
            if (clsUserDataAccess.CheckUserNameAndPassword(Username, Password))
                return true;
            else
                return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static DataTable GetByFilter(string columnName, string value)
        {
            return clsUserDataAccess.GetUsersByFilter(columnName, value);
        }

        public bool AddUser()
        {
            clsUserDataAccess userDataAccess = new clsUserDataAccess();
            return userDataAccess.AddUser(
                _PersonID,
                _UserName,
                _Password,
                _IsActive
            );
        }

        public static DataTable GetUserByNameAndPassword(string Name, string Password)
        {
            return clsUserDataAccess.GetUserByNameAndPassword(Name, Password);
        }

        public static bool UpdateUser(string UserName, string Password)
        {
            return clsUserDataAccess.UpdateUser(UserName, Password);
        }

        public static int GetUserIDFromNameAndPassword(string Name, string Password)
        {
            return clsUserDataAccess.GetUserIDFromLogin(Name, Password);
        }
    }
}
