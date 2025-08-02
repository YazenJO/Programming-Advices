using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccesLayer
{
    public class ManageApplicationTypesDAO
    {
        public static bool GetApplicationTypeByID(int? ApplicationTypeID, ref string ApplicationTypeTitle,
            ref decimal ApplicationFees)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID",
                            (object)ApplicationTypeID ?? DBNull.Value);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                                ApplicationFees = (decimal)reader["ApplicationFees"];
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

        public static int AddNewApplicationType(string ApplicationTypeTitle, decimal ApplicationFees)
        {
            var ApplicationTypeID = -1;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"INSERT INTO ApplicationTypes (ApplicationTypeTitle, ApplicationFees)
                            VALUES (@ApplicationTypeTitle, @ApplicationFees)
                            SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                        command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

                        connection.Open();

                        var result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out var insertedID))
                            ApplicationTypeID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return ApplicationTypeID;
        }

        public static bool UpdateApplicationType(int? ApplicationTypeID, string ApplicationTypeTitle,
            decimal ApplicationFees)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"UPDATE ApplicationTypes  
                            SET 
                            ApplicationTypeTitle = @ApplicationTypeTitle, 
                            ApplicationFees = @ApplicationFees
                            WHERE ApplicationTypeID = @ApplicationTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                        command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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

        public static bool DeleteApplicationType(int? ApplicationTypeID)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"Delete ApplicationTypes 
                                where ApplicationTypeID = @ApplicationTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID",
                            (object)ApplicationTypeID ?? DBNull.Value);

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

        public static bool DoesApplicationTypeExist(int? ApplicationTypeID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT Found = 1 FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID",
                            (object)ApplicationTypeID ?? DBNull.Value);

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

        public static DataTable GetAllApplicationTypes()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM ApplicationTypes";

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