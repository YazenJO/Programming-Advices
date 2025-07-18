using System;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryDataAccrssLayer
{
    public class PermissionsDAO
    {
        public static int GetPermissionsNumber(string permissionName)
        {
            int permissionsNumber = 0;
            string connectionString = clsDataAccessSettings.ConnectionString;

            // Validate input to prevent SQL injection risks
           string[] validColumns = { "FullAccess", "ManageReaders", "ManageBooks", "ManageUsers", "ManagePayments", "LibrarySettings","ManageBorrow" };
            if (!validColumns.Contains(permissionName))
            {
                throw new ArgumentException("Invalid permission name.");
            }

            string query = $"SELECT [{permissionName}] FROM Permissions";  
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int number))
                        {
                            permissionsNumber = number;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);  
                    }
                }
            }

            return permissionsNumber;
        }

        
    }
}