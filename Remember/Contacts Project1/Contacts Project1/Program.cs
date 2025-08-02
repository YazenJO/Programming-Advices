using System;
using System.Data;
using ContactsDB_Business;

namespace Contacts_Project1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataTable dt = clsContact.GetContacts();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}, {row["FirstName"]}, {row["LastName"]}, {row["Email"]}, {row["Phone"]}, {row["Address"]}, {row["DateOfBirth"]}, {row["CountryID"]}");
            }
          
        }
    }
}