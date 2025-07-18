using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccesLayer
{
    public class CountryDAO
    {
        public static bool GetCountryByID(int? CountryID, ref string CountryName)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                CountryName = (string)reader["CountryName"];
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

        public static int AddNewCountry(string CountryName)
        {
            var CountryID = -1;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"INSERT INTO Countries (CountryName)
                            VALUES (@CountryName)
                            SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", CountryName);

                        connection.Open();

                        var result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out var insertedID))
                            CountryID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return CountryID;
        }

        public static bool UpdateCountry(int? CountryID, string CountryName)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"UPDATE Countries  
                            SET 
                            CountryName = @CountryName
                            WHERE CountryID = @CountryID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        command.Parameters.AddWithValue("@CountryName", CountryName);

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

        public static bool DeleteCountry(int? CountryID)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"Delete Countries 
                                where CountryID = @CountryID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

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

        public static bool DoesCountryExist(int? CountryID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT Found = 1 FROM Countries WHERE CountryID = @CountryID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", (object)CountryID ?? DBNull.Value);

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

        public static DataTable GetAllCountries()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM Countries";

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
    }
}