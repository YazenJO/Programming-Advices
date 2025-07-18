using System;
using System.Data;
using LibraryDataAccrssLayer;

namespace LibraryBusnissLayer
{
    public class UsersBL
    {
      
            public enum enMode
            {
                AddNew = 0,
                Update = 1
            };

            public enMode Mode = enMode.AddNew;
            public int UserID { set; get; }
            public string Name { set; get; }
            public string ImageLocation { set; get; }
            public string Gender { set; get; }
            public string Mobile { set; get; }
            public string Facebook { set; get; }
            public DateTime DateOfBrith { set; get; }
            public string Address { set; get; }
            
            public string Email { set; get; }
            public int Permissions{set; get; }
            public string ContactInformation { set; get; }
            public string LibraryCardNumber { set; get; }

            public UsersBL()
            {
                this.UserID = default;
                this.Name = string.Empty;
                this.ImageLocation = string.Empty;
                this.Gender = string.Empty;
                this.Mobile = string.Empty;
                this.Facebook = string.Empty;
                this.DateOfBrith = DateTime.Now;
                this.Address = string.Empty;
                this.ContactInformation = string.Empty;
                this.LibraryCardNumber = string.Empty;
                this.Permissions = default;
                Mode = enMode.AddNew;
            }

            private UsersBL(int UserID, string Name,string ImageLocation,string Email, string Gender, string Mobile, string Facebook, DateTime DateOfBrith
                , string Address, string ContactInformation, string LibraryCardNumber,int Permissions=0)
            {
                this.UserID = UserID;
                this.Name = Name;
                this.ImageLocation = ImageLocation;
                this.Email = Email;
                this.Gender = Gender;
                this.Mobile = Mobile;
                this.Facebook = Facebook;
                this.DateOfBrith = DateOfBrith;
                this.Address = Address;
                
                this.ContactInformation = ContactInformation;
                this.LibraryCardNumber = LibraryCardNumber;
                Mode = enMode.Update;
            }

            private bool _AddNewUser()
            {
                this.UserID = (int)UserData.AddNewUser(this.Name, this.ImageLocation,this.Email,this.Gender, this.Mobile,
                    this.Facebook, this.DateOfBrith, this.Address, this.ContactInformation, this.LibraryCardNumber,this.Permissions);
                
                return (this.UserID != -1);
            }

            private bool _UpdateUser()
                => UserData.UpdateUser(this. UserID, this.Name, this.ImageLocation,this.Email ,this.Gender, this.Mobile, this.Facebook, this.DateOfBrith, this.Address, this.ContactInformation, this.LibraryCardNumber,this.Permissions);

            public static UsersBL Find(int UserID)
            {
                string Name = string.Empty;
                string ImageLocation = string.Empty;
                string Email = string.Empty;
                string Gender = string.Empty;
                string Mobile = string.Empty;
                string Facebook = string.Empty;
                DateTime DateOfBirth = DateTime.Now;
                string Address = string.Empty;
                string ContactInformation = string.Empty;
                string LibraryCardNumber = string.Empty;

                bool IsFound =
                    UserData.GetUserInfoByID(UserID,ref Name,ref ImageLocation,ref Email,ref Gender,ref Mobile,ref Facebook,ref DateOfBirth,ref Address,ref ContactInformation,ref LibraryCardNumber);

                if (IsFound)
                    return new UsersBL(UserID,Name,ImageLocation,Email,Gender,Mobile,Facebook,DateOfBirth,Address,ContactInformation,LibraryCardNumber);
                else
                    return null;
            }
            public static UsersBL FindReader(int UserID)
            {
                string Name = string.Empty;
                string ImageLocation = string.Empty;
                string Email = string.Empty;
                string Gender = string.Empty;
                string Mobile = string.Empty;
                string Facebook = string.Empty;
                DateTime DateOfBirth = DateTime.Now;
                string Address = string.Empty;
                string ContactInformation = string.Empty;
                string LibraryCardNumber = string.Empty;

                bool IsFound =
                    UserData.GetUserInfoByID(UserID,ref Name,ref ImageLocation,ref Email,ref Gender,ref Mobile,ref Facebook,ref DateOfBirth,ref Address,ref ContactInformation,ref LibraryCardNumber);

                if (IsFound)
                    return new UsersBL(UserID,Name,ImageLocation,Email,Gender,Mobile,Facebook,DateOfBirth,Address,ContactInformation,LibraryCardNumber);
                else
                    return null;
            }

            public static UsersBL FindBYLibraryCardNumber(string LibraryCardNumber)
            {
                int UserID = -1;
                string Name = default;
                string ImageLocation = default;
                string Email = default;
                string Gender =default;
                string Mobile = default;
                string Facebook = default;
                DateTime DateOfBirth = DateTime.Now;
                string Address = default;
                string ContactInformation = default;

                bool IsFound = UserData.GetUserInfoByLibrartCardNumber(LibraryCardNumber,ref UserID,ref Name, ref ImageLocation, ref Email,ref Gender,
                    ref Mobile, ref Facebook, ref DateOfBirth, ref Address, ref ContactInformation);
                
                if (IsFound)
                    return new UsersBL(UserID, Name, ImageLocation,Email, Gender, Mobile, Facebook, DateOfBirth, Address, ContactInformation, LibraryCardNumber);
                else
                {
                    return null;
                }

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
                        else
                        {
                            return false;
                        }

                    case enMode.Update:
                        return _UpdateUser();
                }

                return false;
            }

            public static bool DeleteUser(int UserID)
                => UserData.DeleteUser(UserID);

            public static bool DoesUserExist(int UserID)
                => UserData.IsUserExist(UserID);
            public static bool DoesUserExist(string ibraryCardNumber)
                => UserData.IsUserExist(ibraryCardNumber);

            public static DataTable GetUsers()
                => UserData.GetAllUsers();
            
            public static DataTable GetReaders()
                => UserData.GetAllReaders();

            public static DataTable GetFilteredReaders(string FilterName, string Value)
                => UserData.GetFilterdReaderss(FilterName, Value);

            public static bool RememberMeCheck(string Username, string Password)
            {
                return UserData.RememberMeCheck(Username, Password);
            }
            public static DataTable GetReadersByGender(string Gender)
                => UserData.GetReaderssByGender(Gender);

            public static DataTable GetReadersBYBirthDate(DateTime startDate, DateTime endDate)
                => UserData.GetReadersByBirthDateDate(startDate, endDate);

            public static int GetUserPermissions(int UserID)
            {
                int permissions = 0;
                if (UserData.GetPermissionOFTheUser(UserID, ref permissions))
                {
                    return permissions;
                }

                return permissions;
            }
            public static bool EnableRememberMe(string Username, string Password)
            {
                return UserData.MarkAsRememberMe(Username, Password);
            }

            public static bool DiableRememberMe(string Username, string Password)
            {
                return UserData.UnmarkAsRememberMe(Username, Password);
            }

            
            public static int Login(string Username, string Password)
            {
                return UserData.Login(Username, Password);
            }

            public static string GetUserNameByUserID(int UserID)
            {
                string UserName=default;
                if (UserData.GetUserNameByUserID(UserID,ref UserName))
                
                    return UserName;
                return "Cant Find THe UserName";
            }

            public static bool ChckAccessPermission(int UserID,string PermissionName)
            {
                int UserPermission = GetUserPermissions(UserID);
                if (UserPermission == PermissionsDAO.GetPermissionsNumber("FullAccess"))
                {
                    return true;
                }

                int permissions = PermissionsDAO.GetPermissionsNumber(PermissionName);
                if (( permissions & UserPermission)==permissions)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
