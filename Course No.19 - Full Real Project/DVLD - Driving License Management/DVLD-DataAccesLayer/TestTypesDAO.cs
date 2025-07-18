using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccesLayer
{
    public class TestTypesDAO
    {
        public static bool GetTestTypeByID(int? TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription,
            ref decimal TestTypeFees)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", (object)TestTypeID ?? DBNull.Value);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
                                TestTypeFees = (decimal)reader["TestTypeFees"];
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

        public static int AddNewTestType(string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            var TestTypeID = -1;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"INSERT INTO TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees)
                            VALUES (@TestTypeTitle, @TestTypeDescription, @TestTypeFees)
                            SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

                        connection.Open();

                        var result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out var insertedID))
                            TestTypeID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return TestTypeID;
        }

        public static bool UpdateTestType(int? TestTypeID, string TestTypeTitle, string TestTypeDescription,
            decimal TestTypeFees)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"UPDATE TestTypes  
                            SET 
                            TestTypeTitle = @TestTypeTitle, 
                            TestTypeDescription = @TestTypeDescription, 
                            TestTypeFees = @TestTypeFees
                            WHERE TestTypeID = @TestTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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

        public static bool DeleteTestType(int? TestTypeID)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"Delete TestTypes 
                                where TestTypeID = @TestTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", (object)TestTypeID ?? DBNull.Value);

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

        public static bool DoesTestTypeExist(int? TestTypeID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT Found = 1 FROM TestTypes WHERE TestTypeID = @TestTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", (object)TestTypeID ?? DBNull.Value);

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

        public static DataTable GetAllTestTypes()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM TestTypes";

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