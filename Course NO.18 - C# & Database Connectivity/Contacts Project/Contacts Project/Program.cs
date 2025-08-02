using ContactsBusnissLayar;
using System;
using System.Data;
using ContactsBusnissLayar.Properties;

namespace Contacts_Project
{
  internal class Program
  {
    static void TestFindContacts(int id)
    {
        clsContact contact =  (clsContact.FInd(id));
        if (contact != null)
        {
         
            Console.WriteLine($"First Name: {contact.FirstName}");
            Console.WriteLine($"Last Name: {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine($"Address: {contact.Address}");
            Console.WriteLine($"Date of Birth: {contact.DateOfBirth}");
            Console.WriteLine($"Country ID: {contact.CountryID}");
            Console.WriteLine($"Image Path: {contact.ImagePath}");
            
        }
        else
        {
            Console.WriteLine("Contact ["+id+"] not found");
        }

    }
    static void TestAddnewContact()
    {
        clsContact contact = new clsContact();
        contact.FirstName = "John Doe";
        contact.LastName = "Smith";
        contact.Email = "john.doe@example.com";
        contact.Phone = "123-456-7890";
        contact.Address = "123 Main St";
        contact.DateOfBirth = new DateTime(2000, 1, 1);
        contact.CountryID = 1;
        contact.ImagePath = @"C:\Users\yazen\OneDrive\Desktop\C++\Course NO.18 - C# & Database Connectivity\Contacts Project\Images\John Doe.jpg";
        if (contact.Save())
        {
            Console.WriteLine("Contact added successfully. Contact ID: " + contact.ID); 
        }
        else
        {
            Console.WriteLine("Failed to add contact");
        }
        
        
    }

    static void TestUpdateContact(int id)
    {
        clsContact contact = clsContact.FInd(id);
        if (contact != null)
        {
            contact.FirstName = "Tareq";
            contact.LastName = "Mohamed";
            contact.Email = "yazen.mohamed@example.com";
            contact.Phone = "987-654-3210";
            contact.Address = "456 Elm St";
            contact.DateOfBirth = new DateTime(2005, 1, 8);
            contact.CountryID = 2;
            contact.ImagePath = @"C:\Users\yazen\OneDrive\Desktop\C++\Course NO.18 - C# & Database Connectivity\Contacts Project\Images\Yazen Mohamed.jpg";
            if (contact.Save())
            {
                Console.WriteLine("Contact updated successfully");
            }

        }

    }

    static void TestDeleteContact(int id)
    {
        if (clsContact.IsExist(id))
        {
            if (clsContact.DeleteContact(id))
            {
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Contact not deleted successfully");
            }
        }
        else
            Console.WriteLine("Contact Is not Exist ");


    }

    static void ListContacts()
    {
        DataTable datatable = clsContact.ListContacts();
        foreach (DataRow row in datatable.Rows)
        {
            Console.WriteLine($"ID: {row["ContactID"]}, First Name: {row["FirstName"]}, Last Name: {row["LastName"]}");
        }

    }

    static void TestFindCountriesByName(string name)
    {   
        
        
        
        
    }
    static void TestFindCoountries(int id) 
    {
        clsCountry Country =  (clsCountry.GetCountry(id));
        if (Country != null)
        {
         
            Console.WriteLine($"Countrt ID: {Country.ID}");
            Console.WriteLine($"Countrt Name: {Country.CountryName}");
        }
        else
        {
            Console.WriteLine("Contact ["+id+"] not found");
        }

    }
    static void TestAddnewCoountry()
    {
        clsCountry Country = new clsCountry();
        Country.CountryName = "test";
        if (Country.Save())
        {
            Console.WriteLine("Country added successfully. Country ID: " + Country.ID); 
        }
        else
        {
            Console.WriteLine("Failed to add Country");
        }
        
        
    }
    static void TestDeleteCountry(int id)
    {
        if (clsCountry.IsExist(id))
        {
            if (clsContact.DeleteContact(id))
            {
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Contact not deleted successfully");
            }
        }
        else
            Console.WriteLine("Contact Is not Exist ");


    }
    static void TestUpdateCountry(int id)
    {
        clsCountry Country = clsCountry.GetCountry(id);
        if (Country != null)
        {
            Country.CountryName = "UAE";
           
            if (Country.Save()){
                Console.WriteLine("Contact updated successfully");
            }
            else
            {
                Console.WriteLine("Contact Not Updated");
            }

        }

    }
      static void ListCountry()
        {
            DataTable datatable = clsCountry.ListCountries();
            foreach (DataRow row in datatable.Rows)
            {
                Console.WriteLine($"ID: {row["CountryID"]}, Country Name: {row["CountryName"]}");
            }
    
        }

    public static void Main(string[] args)
    {
        ListCountry();
    }
    
  }
}