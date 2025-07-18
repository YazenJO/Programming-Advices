using System;
using System.Data;
using ContactsDB_DataAccess;

namespace ContactsDB_Business
{
    public class clsContact
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? ContactID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }
        public int CountryID { set; get; }
        public string ImagePath { set; get; }

        public clsContact()
        {
            this.ContactID = null;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
            this.Address = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = null;
            Mode = enMode.AddNew;
        }
        private clsContact(int? ContactID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            this.ContactID = ContactID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }
        private bool _AddNewContact()
        {
            this.ContactID = (int?)clsContactData.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
            return (this.ContactID != -1);
        }
        private bool _UpdateContact()
            => clsContactData.UpdateContact(this.ContactID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        public static clsContact Find(int? ContactID)
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            string Phone = string.Empty;
            string Address = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            int CountryID = -1;
            string ImagePath = null;

            bool IsFound = clsContactData.GetContactByID(ContactID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref CountryID, ref ImagePath);

            if(IsFound)
                return new clsContact(ContactID, FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewContact())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateContact();
            }
            return false;
        }
        public static bool DeleteContact(int? ContactID)
            => clsContactData.DeleteContact(ContactID);
        public static bool DoesContactExist(int? ContactID)
            => clsContactData.DoesContactExist(ContactID);
        public static DataTable GetContacts()
            => clsContactData.GetAllContacts();
    }
}
