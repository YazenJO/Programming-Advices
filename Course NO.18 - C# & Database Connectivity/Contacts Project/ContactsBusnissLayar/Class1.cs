using System;
using System.Data;
using ContactsDataLayer;
using ContactsDataLayer.Properties;

namespace ContactsBusnissLayar
{
    public class clsContact
    {
        public enum enMode{AddNew=0,Update=1}
        public enMode Mode =enMode.AddNew;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        public clsContact()
        {
            ID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            DateOfBirth = DateTime.Now;
            CountryID = -1;
            ImagePath = "";
            
            
            Mode = enMode.AddNew;   
        }
        private clsContact(int ID,string FirstName, string LastName, string Email, string Phone,string Address,DateTime DateOfBirth,int CountryID,string ImagePath)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }
        public static clsContact FInd(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBrith = DateTime.Now;
            int CountryID = 1;
            
            if (ContactsDataLayer.clsContactsDataAccess.GetContactInfoById(ID,ref FirstName,ref LastName,ref Email,ref Phone,ref Address,ref DateOfBrith,ref CountryID,ref ImagePath))
            {
                return new clsContact(ID,FirstName,LastName,Email,Phone,Address,DateOfBrith,CountryID,ImagePath);
                
            }
            else
            {
                return null;
            }


            
        }

        public static bool DeleteContact(int id)
        {
            return clsContactsDataAccess.DeleteContact(id);
        }

        private bool _AddNewContact()
        {
           this.ID=clsContactsDataAccess.AddNewContact(this.FirstName,this.LastName,this.Email,this.Phone,this.Address,this.DateOfBirth,this.CountryID,this.ImagePath);
           if (ID==-1)
           {
               return false;
           }
           return true; 
        }
        private bool _UpdateContact()
        {
            return clsContactsDataAccess.UpdateContact(this.ID,this.FirstName,this.LastName,this.Email,this.Phone,this.Address,this.DateOfBirth,this.CountryID,this.ImagePath);
        }

        public static DataTable ListContacts()
        {
            return clsContactsDataAccess.ListContacts();
        }

       public static bool IsExist(int id)
        {
            return clsContactsDataAccess.IsExist(id);
        }
       
        public  bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
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
        
    }

    
}