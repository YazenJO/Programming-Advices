using System;
using System.Data;
using DVLD_DataAccesLayer;

namespace DVLD_BusnissLayer
{
    public class PersonBL
    {
        public enum enMode
        {
            AddNew = 0,
            Update = 1
        }

        public enMode Mode = enMode.AddNew;

        public PersonBL()
        {
            PersonID = null;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = null;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = 0;
            Address = string.Empty;
            Phone = string.Empty;
            Email = null;
            NationalityCountryID = -1;
            ImagePath = null;
            Mode = enMode.AddNew;
        }

        private PersonBL(int? PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }

        public int? PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        private bool _AddNewPerson()
        {
            PersonID = PersonDAO.AddNewPerson(NationalNo, FirstName, SecondName,
                ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email,
                NationalityCountryID, ImagePath);
            return PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return PersonDAO.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName,
                LastName, DateOfBirth, Gendor, Address, Phone, Email,
                NationalityCountryID, ImagePath);
        }

        public static PersonBL Find(int? PersonID)
        {
            var NationalNo = string.Empty;
            var FirstName = string.Empty;
            var SecondName = string.Empty;
            string ThirdName = null;
            var LastName = string.Empty;
            var DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            var Address = string.Empty;
            var Phone = string.Empty;
            string Email = null;
            var NationalityCountryID = -1;
            string ImagePath = null;

            var IsFound = PersonDAO.GetPersonByID(PersonID, ref NationalNo, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new PersonBL(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            return null;
        }

        public static PersonBL Find(string NationalNo)
        {
            int? PersonId = -1;
            var FirstName = string.Empty;
            var SecondName = string.Empty;
            string ThirdName = null;
            var LastName = string.Empty;
            var DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            var Address = string.Empty;
            var Phone = string.Empty;
            string Email = null;
            var NationalityCountryID = -1;
            string ImagePath = null;

            var IsFound = PersonDAO.GetPersonByNationalID(NationalNo, ref PersonId, ref FirstName, ref SecondName,
                ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath);

            if (IsFound)
                return new PersonBL(PersonId, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                    Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static bool DeletePerson(int? PersonID)
        {
            return PersonDAO.DeletePerson(PersonID);
        }

        public static bool DoesPersonExist(int? PersonID)
        {
            return PersonDAO.DoesPersonExist(PersonID);
        }

        public static bool DoesPersonExistByNationalNo(string NationalNo)
        {
            return PersonDAO.DoesPersonExistByNationalNo(NationalNo);
        }

        public static DataTable GetPeople()
        {
            return PersonDAO.GetAllPeople();
        }

        public static DataTable GetFilterdPeople(string FilterName, string Value)
        {
            return PersonDAO.GetFilterdPeople(FilterName, Value);
        }

        public static DataTable GetPeopleView()
        {
            return PersonDAO.GetAllPeople_View();
        }

        public static DataTable GetPeopleByBirthDateDate(DateTime From, DateTime To)
        {
            return PersonDAO.GetPeopleByBirthDateDate(From, To);
        }
    }
}