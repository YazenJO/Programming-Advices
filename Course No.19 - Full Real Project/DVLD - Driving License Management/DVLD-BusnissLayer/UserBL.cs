using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class UserBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public UserBL()
        {
            UserID = null;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
            Mode = enMode.AddNew;
        }

        private UserBL(int? UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            Mode = enMode.Update;
        }

        public int? UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }

        private bool _AddNewUser()
        {
            UserID = UserDAO.AddNewUser(PersonID, UserName, Password, IsActive);
            return UserID != -1;
        }

        private bool _UpdateUser()
        {
            return UserDAO.UpdateUser(UserID, PersonID, UserName, Password, IsActive);
        }

        public static UserBL Find(int? UserID)
        {
            var PersonID = -1;
            var UserName = string.Empty;
            var Password = string.Empty;
            var IsActive = false;

            var IsFound = UserDAO.GetUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new UserBL(UserID, PersonID, UserName, Password, IsActive);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool DeleteUser(int? UserID)
        {
            return UserDAO.DeleteUser(UserID);
        }

        public static bool DoesUserExist(int? UserID)
        {
            return UserDAO.DoesUserExist(UserID);
        }

        public static bool DoesUserExistByPersonID(int? PersonID)
        {
            return UserDAO.DoesUserExistByPersonID(PersonID);
        }

        public static DataTable GetUsers()
        {
            return UserDAO.GetAllUsers();
        }

        public static int Login(string Username, string Password)
        {
            return UserDAO.Login(Username, Password);
        }

        public static DataTable GetUsers_View()
        {
            return UserDAO.GetAllUsersFromUsersView();
        }

        public static bool DoesUserNameExist(string UserName)
        {
            return UserDAO.DoesUserNameExist(UserName);
        }


        public static DataTable GetFilterdUsers(string FilterName, string Value)
        {
            return UserDAO.GetFilterdUsers(FilterName, Value);
        }
    }
}