
using System;
using System.Data;
using System.Data.SqlClient;
using ContactsDataLayer.Properties;


namespace ContactsDataLayer
{
    public class clsContactsDataAccess
    {
        public static bool GetContactInfoById(int id, ref string FirstName, ref string LastName, ref string Email,
            ref string Phone,
            ref string Address, ref DateTime DateOfBrith, ref int CountryID, ref string ImagePath)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Contacts WHERE ContactID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = reader["FirstName"].ToString();
                    LastName = reader["LastName"].ToString();
                    Email = reader["Email"].ToString();
                    Phone = reader["Phone"].ToString();
                    Address = reader["Address"].ToString();
                    DateOfBrith = Convert.ToDateTime(reader["DateOfBirth"]);
                    CountryID = Convert.ToInt32(reader["CountryID"]);
                    
                    if(reader["ImagePath"]!=DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }  
                    else
                    {
                        ImagePath = "";
                    }
                    
                    isfound = true;

                }
                else
                    isfound = false;

                reader.Close();


            }
            catch (Exception e)
            {

                isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return isfound; 
        }

        public static int AddNewContact(string FirstName, string LastName, string Email,
            string Phone,
            string Address, DateTime DateOfBrith, int CountryID, string ImagePath)
        {
            int ContactID = -1;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO Contacts (FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath) VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @CountryID, @ImagePath)
                              SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);   
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBrith);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath !="")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    ContactID = ID;
                }
                else
                {
                    ContactID = -1;
                }

            }
            catch (Exception e)
            {


            }
            finally
            {
                connection.Close();
            }

            
            return ContactID;
        }

        public static bool UpdateContact(int ContactID,string FirstName, string LastName, string Email,
            string Phone,
            string Address, DateTime DateOfBrith, int CountryID, string ImagePath)
        {
            int RowsAffected = 0;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update  Contacts 
                            set FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                Address = @Address, 
                                DateOfBirth = @DateOfBirth,
                                CountryID = @CountryID,
                                ImagePath =@ImagePath
                                where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);   
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBrith);
         
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath !="")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
              
            }
            catch (Exception e)
            {
                
                return false;
            }
            finally
            {
                connection.Close(); 
            }


            return (RowsAffected > 0);

        }

        public static bool DeleteContact(int id)
        {
            int rowsAffected = 0;
            SqlConnection connection =new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "DELETE FROM Contacts WHERE ContactID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable ListContacts()
        {
            SqlConnection connection =new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Contacts";
            SqlCommand command = new SqlCommand(query,connection);
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                connection.Close();
            }
            return dt;
            
        }

        public static bool IsExist(int id)
        {
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT Found=1 FROM Contacts WHERE ContactID=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();

            }
            catch (Exception e)
            {
             
                isFound=false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;  
            
        }








    }}

   
