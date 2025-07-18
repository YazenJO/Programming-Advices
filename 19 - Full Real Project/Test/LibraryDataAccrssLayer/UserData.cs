using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace LibraryDataAccrssLayer
{
    public class UserData
    {
        public static bool GetUserInfoByID(int ID, ref string Name,ref string ImageLocation,ref string Email,ref string Gender,ref string Mobile,ref string Facebook,ref DateTime DateOfBrith
            ,ref string Address, ref string ContactInformation,
            ref string LibraryCardNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Name = (string)reader["Name"];
                    Email = (string)reader["Email"];
                    Gender = (string)reader["Gender"];
                    Mobile = (string)reader["Mobile"];
                    Facebook = (string)reader["Facebook"];
                    DateOfBrith = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    ContactInformation = (string)reader["ContactInformation"];
                    LibraryCardNumber = (string)reader["LibraryCardNumber"];
                    if (reader["ImageLocation"] != DBNull.Value)
                        ImageLocation = (string)reader["ImageLocation"];
                    else
                        ImageLocation = "Empety :(";
                }
                    
                else
                {
                    isFound=false;
                }

                reader.Close();

            }
            catch (Exception e)
            {
                
                isFound = false;
            }
           
            return isFound;
    
        }

        public static bool GetUserInfoByLibrartCardNumber(string cardNumber,ref int UserID, ref string Name, ref string ImageLocation,
            ref string Email,ref string Gender, ref string Mobile, ref string Facebook, ref DateTime DateOfBrith
            , ref string Address, ref string ContactInformation)
            
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Users where LibraryCardNumber=@LibraryCardNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LibraryCardNumber", cardNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    Name = (string)reader["Name"];
                   
                    Email = (string)reader["Email"];
                    Gender = (string)reader["Gender"];
                    Mobile = (string)reader["Mobile"];
                    Facebook = (string)reader["Facebook"];
                    DateOfBrith = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    ContactInformation = (string)reader["ContactInformation"];
                    if (reader["ImageLocation"] != DBNull.Value)
                        ImageLocation = (string)reader["ImageLocation"];
                    else
                        ImageLocation = "Empety :(";
                    
                }
                else
                {
                    isFound = false;
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
            return isFound;
        }

        public static int AddNewUser(string Name, string ImageLocation,  string Email,string Gender, string Mobile, string Facebook, DateTime DateOfBrith
            , string Address, string ContactInformation, string LibraryCardNumber,int Permissions=0)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Users (Name, ImageLocation, Email,Gender, Mobile, Facebook, DateOfBirth, Address, ContactInformation, LibraryCardNumber,Permissions)
                OUTPUT INSERTED.UserID
                VALUES (@Name, @ImageLocation,@Email,@Gender, @Mobile, @Facebook, @DateOfBrith, @Address, @ContactInformation, @LibraryCardNumber,@Permissions) SELECT  SCOPE_IDENTITY();";
           
             
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@ImageLocation", ImageLocation);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Mobile", Mobile);
            command.Parameters.AddWithValue("@Facebook", Facebook);
            command.Parameters.AddWithValue("@DateOfBrith", DateOfBrith);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ContactInformation", ContactInformation);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return ID;
            
            
            
        }

        public static bool UpdateUser(int ID, string Name, 
            string ImageLocation, string Email,string Gender, string Mobile, string Facebook, DateTime DateOfBrith
            , string Address,string ContactInformation, string LibraryCardNumber,int Permissions=0)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Users SET Name=@Name, ImageLocation=@ImageLocation,Email=@Email, Gender=@Gender, 
                             Mobile=@Mobile, Facebook=@Facebook, DateOfBirth=@DateOfBirth, Address=@Address, ContactInformation=@ContactInformation,
                             LibraryCardNumber=@LibraryCardNumber ,Permissions=@Permissions WHERE UserID=@UserID";

            SqlCommand command = new SqlCommand(query,connection);
            
            command.Parameters.AddWithValue("@UserID", ID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@ImageLocation", ImageLocation);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Mobile", Mobile);
            command.Parameters.AddWithValue("@Facebook", Facebook);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBrith);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@ContactInformation", ContactInformation);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            
    
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

        public static bool DeleteUser(int ID)
        {
            int rowsAffected = 0;
            string query = @"
        BEGIN TRANSACTION;
        UPDATE Payments SET UserID = NULL WHERE UserID = @UserID;
        DELETE FROM Users WHERE UserID = @UserID;
        COMMIT TRANSACTION;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
               
                return false;
            }
            catch (Exception ex)
            {
               
                return false;
            }

            return rowsAffected > 0;
        }


        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT UserID,Name,ImageLocation,Gender,Mobile,Facebook,Email,DateOfBirth,Address,ContactInformation,LibraryCardNumber,RememberMe FROM Users";
            SqlCommand command = new SqlCommand(query, connection);
            
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
        public static DataTable GetAllReaders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ReadersView  ";
            SqlCommand command = new SqlCommand(query, connection);
            
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

        public static DataTable GetFilterdReaderss(string FilterName, string Value)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ReadersView U WHERE " + FilterName + " LIKE '%" + Value + "%'";
            SqlCommand command = new SqlCommand(query, connection);

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
        public static bool IsUserExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", ID);
           
            try
            {
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();
               isExist = reader.HasRows;
               reader.Close();

            }
            catch (Exception e)
            {
                isExist = false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
               
        }
        public static bool IsUserExist(string LibraryCardNumber)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT count(*) FROM Users WHERE LibraryCardNumber = @LibraryCardNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
           
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                isExist = count > 0;
              

            }
            catch (Exception e)
            {
                isExist = false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
               
        }

        public static bool RememberMeCheck(string username, string LibraryCardNumber)
        {
            bool RememberMe = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select RememberMe WHERE Name=@Username AND LibraryCardNumber=@LibraryCardNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool remember))
                {
                    RememberMe = remember;
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return RememberMe;
            
        }

        public static bool MarkAsRememberMe(string username, string LibraryCardNumber)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET RememberMe=1 WHERE Name=@Username AND LibraryCardNumber=@LibraryCardNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool UnmarkAsRememberMe(string username, string LibraryCardNumber)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Users SET RememberMe=0 WHERE Name=@Username AND LibraryCardNumber=@LibraryCardNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@LibraryCardNumber", LibraryCardNumber);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static int Login(string username, string libraryCardNumber)
        {
            const string query = @"
        SELECT UserID FROM Users 
        WHERE Name COLLATE Latin1_General_CS_AS = @Username 
        AND LibraryCardNumber COLLATE Latin1_General_CS_AS = @LibraryCardNumber";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use parameterized queries to prevent SQL Injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@LibraryCardNumber", libraryCardNumber);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    return result != null && int.TryParse(result.ToString(), out int userID) 
                        ? userID 
                        : -1; 
                }
            }
            catch (Exception ex)
            {
            
                return -1; 
            }
        }




        public static bool GetUserNameByUserID(int UserId,ref string UserName)
        {
            string username = string.Empty;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Name FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserId);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    username = result.ToString();
                   
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return (username!=null);
        }
        
        public static DataTable GetReaderssByGender(string Gender)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ReadersView WHERE Gender = '" + Gender + "'";
            SqlCommand command = new SqlCommand(query, connection);

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
        
        public static DataTable GetReadersByBirthDateDate(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT  *  FROM ReadersView WHERE DateOfBirth >= @StartDate AND DateOfBirth <= @EndDate ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
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

        public static bool GetPermissionOFTheUser(int UserID,ref int Permission)
        {
            bool permission = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Permissions FROM Users WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!= null && int.TryParse(result.ToString(), out int number))
                {
                    permission = true;
                    
                    Permission = number;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return permission;
        }
       
        
    }
}