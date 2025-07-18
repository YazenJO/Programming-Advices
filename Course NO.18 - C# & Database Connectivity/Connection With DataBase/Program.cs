using System;
using System.Data.SqlClient;

namespace Connection_With_DataBase
{

    internal class Program
    {
        static string connectionstring = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";
        static void PrintAllContatcs()
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT * FROM Contacts";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID: {contactID}");
                    Console.WriteLine($"Name: {firstName} {lastName}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Phone: {phone}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Country ID: {countryID}");
                    Console.WriteLine();


                }
                reader.Close();
                connection.Close();




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        static void PrintAllContatcsWithFirstName(string Firstname)
        {
            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT * FROM Contacts WHERE FirstName=@Firstname";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int contactID = (int)reader["ContactID"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        string email = (string)reader["Email"];
                        string phone = (string)reader["Phone"];
                        string address = (string)reader["Address"];
                        int countryID = (int)reader["CountryID"];

                        Console.WriteLine($"Contact ID: {contactID}");
                        Console.WriteLine($"Name: {firstName} {lastName}");
                        Console.WriteLine($"Email: {email}");
                        Console.WriteLine($"Phone: {phone}");
                        Console.WriteLine($"Address: {address}");
                        Console.WriteLine($"Country ID: {countryID}");
                        Console.WriteLine();

                    }


                    reader.Close();
                    connection.Close();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            }
        }
        static void PrintAllContatcsWithFirstNamelike(string startwith)
        {
            SqlConnection connection = new SqlConnection(connectionstring);

            string query = "SELECT * FROM Contacts  WHERE FirstName LIKE @startwith+'%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@startwith", startwith);

            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int contactID = (int)reader["ContactID"];
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        string email = (string)reader["Email"];
                        string phone = (string)reader["Phone"];
                        string address = (string)reader["Address"];
                        int countryID = (int)reader["CountryID"];

                        Console.WriteLine($"Contact ID: {contactID}");
                        Console.WriteLine($"Name: {firstName} {lastName}");
                        Console.WriteLine($"Email: {email}");
                        Console.WriteLine($"Phone: {phone}");
                        Console.WriteLine($"Address: {address}");
                        Console.WriteLine($"Country ID: {countryID}");
                        Console.WriteLine();

                    }


                    reader.Close();
                    connection.Close();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            }
        }
        static string GetFirstName(int ContactID)
        {
            string FirstName = "";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT FirstName FROM Contacts WHERE ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result == null)
                    FirstName = "";



                FirstName = result.ToString();







                connection.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }


            return FirstName;
        }
        struct stContactInfo
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }


        }
        static bool FindContactById(int ContactID, ref stContactInfo contactInfo)
        {
            bool isFound=false;
            SqlConnection Connection = new SqlConnection(connectionstring);
            string query = "SELECT * FROM Contacts WHERE ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    contactInfo.ID = (int)reader["ContactID"];
                    contactInfo.FirstName = (string)reader["FirstName"];
                    contactInfo.LastName = (string)reader["LastName"];
                    contactInfo.Email = (string)reader["Email"];
                    contactInfo.Phone = (string)reader["Phone"];
                    contactInfo.Address = (string)reader["Address"];
                    contactInfo.CountryID = (int)reader["CountryID"];


                }
                else
                    isFound = false;

                reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



            return isFound;
        }
        static void AddContactToDb(stContactInfo newComtact)
        {
           SqlConnection Connection= new SqlConnection(connectionstring);
            string query = "INSERT INTO [dbo].[Contacts] ([FirstName], [LastName], [Email], [Phone], [Address], [CountryID]) \r\nVALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID);\r\n";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@FirstName", newComtact.FirstName);
            command.Parameters.AddWithValue("@LastName", newComtact.LastName);
            command.Parameters.AddWithValue("@Email", newComtact.Email);
            command.Parameters.AddWithValue("@Phone", newComtact.Phone);
            command.Parameters.AddWithValue("@Address", newComtact.Address);
            command.Parameters.AddWithValue("@CountryID", newComtact.CountryID);
            try {
                   Connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) {
                    Console.WriteLine("\nContact added successfully!");
                }
                else {
                    Console.WriteLine("\n Failed To Add The Contact :(");
                }
              ;

                Connection.Close();

            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            
            }





        }
        static void AddNewContactAndGetID(stContactInfo newComtact)
        {
            SqlConnection Connection = new SqlConnection(connectionstring);
            string query = @"INSERT INTO [dbo].[Contacts] ([FirstName], [LastName], [Email], [Phone], [Address], [CountryID]) VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @CountryID); 
                select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@FirstName", newComtact.FirstName);
            command.Parameters.AddWithValue("@LastName", newComtact.LastName);
            command.Parameters.AddWithValue("@Email", newComtact.Email);
            command.Parameters.AddWithValue("@Phone", newComtact.Phone);
            command.Parameters.AddWithValue("@Address", newComtact.Address);
            command.Parameters.AddWithValue("@CountryID", newComtact.CountryID);
            try
            {
                Connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(),out int insertedID))
                {
                    Console.WriteLine($"Newly inserted ID: {insertedID}");
                }
                else
                {
                    Console.WriteLine($"Failed to retrive the inserted ID.");
                }
              ;

                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }

        }
        static void UpdateContact(int contactid,stContactInfo ContactInfo) { 
            SqlConnection Connection = new SqlConnection(connectionstring);
            string query = "UPDATE Contacts SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, Address=@Address, CountryID=@CountryID WHERE ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);
            command.Parameters.AddWithValue("@ContactID", contactid);
            try {
                Connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("\nContact updated successfully!");
                }
                else
                {
                    Console.WriteLine("\nFailed To Update The Contact :(");
                }
              ;
            }
            catch(Exception ex) { Console.WriteLine("Error: " + ex.Message); }




        }
        static void DeleteContact(int contactid) { 
            SqlConnection Connection = new SqlConnection( connectionstring);
            string query = "DELETE FROM Contacts WHERE ContactID=@ContactID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ContactID", contactid);
            try {
                Connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) {
                    Console.WriteLine("Contact Deleted Succefully");
                }
                else {
                    Console.WriteLine("Failed To Delete The Contact");
                }


                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
        static void Main(string[] args)
        {
            stContactInfo contactInfo = new stContactInfo();
            contactInfo.FirstName = "Tareq";
            contactInfo.LastName = "Bilal";
            contactInfo.Email = "Tareq.bilal@gmail.com";
            contactInfo.Phone = "0123456789";
            contactInfo.Address = "Amman";
            contactInfo.CountryID = 1;

            DeleteContact(4);


        }
    }
}
    

