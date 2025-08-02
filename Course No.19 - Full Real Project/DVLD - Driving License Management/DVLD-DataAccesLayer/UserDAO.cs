using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccesLayer
{
    public class UserDAO
    {
        public static bool GetUserByID(int? UserID, ref int PersonID, ref string UserName, ref string Password,
            ref bool IsActive)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM Users WHERE UserID = @UserID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                PersonID = (int)reader["PersonID"];
                                UserName = (string)reader["UserName"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                            }
                            else
                            {
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive)
        {
            var UserID = -1;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive)
                            VALUES (@PersonID, @UserName, @Password, @IsActive)
                            SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        connection.Open();

                        var result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out var insertedID))
                            UserID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return UserID;
        }

        public static bool UpdateUser(int? UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"UPDATE Users  
                            SET 
                            PersonID = @PersonID, 
                            UserName = @UserName, 
                            Password = @Password, 
                            IsActive = @IsActive
                            WHERE UserID = @UserID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return rowsAffected > 0;
        }

        public static bool DeleteUser(int? UserID)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"Delete Users 
                                where UserID = @UserID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return rowsAffected > 0;
        }

        public static bool DoesUserExist(int? UserID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT Found = 1 FROM Users WHERE UserID = @UserID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", (object)UserID ?? DBNull.Value);

                        connection.Open();
                        var reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }

        public static bool DoesUserExistByPersonID(int? PersonID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT Found = 1 FROM Users WHERE PersonID = @PersonID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", (object)PersonID ?? DBNull.Value);

                        connection.Open();
                        var reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetAllUsers()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM Users";

                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return dt;
        }

        public static DataTable GetAllUsersFromUsersView()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM Userss_View";

                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return dt;
        }

        public static DataTable GetFilterdUsers(string FilterName, string Value)
        {
            var dt = new DataTable();
            var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString);
            var query = "SELECT * FROM Userss_View  WHERE " + FilterName + " LIKE '%" + Value + "%'";
            var command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);

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

        public static int Login(string username, string libraryCardNumber)
        {
            const string query = @"
                         SELECT UserID FROM Users 
                            WHERE UserName COLLATE Latin1_General_CS_AS = @Username 
                            AND Password COLLATE Latin1_General_CS_AS = @LibraryCardNumber  AND IsActive='true' ";

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    // Use parameterized queries to prevent SQL Injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@LibraryCardNumber", libraryCardNumber);

                    connection.Open();
                    var result = command.ExecuteScalar();

                    return result != null && int.TryParse(result.ToString(), out var userID)
                        ? userID
                        : -1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static bool DoesUserNameExist(string UserName)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT Found = 1 FROM Users WHERE UserName = @UserName";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", UserName);

                        connection.Open();
                        var reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
    }
}