using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccesLayer
{
    public class LocalDLApplicationDAO
    {
        public static bool GetLocalDrivingLicenseApplicationByID(int? LocalDrivingLicenseApplicationID,
            ref int ApplicationID, ref int LicenseClassID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query =
                        "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                            (object)LocalDrivingLicenseApplicationID ?? DBNull.Value);

                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                ApplicationID = (int)reader["ApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
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

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            var LocalDrivingLicenseApplicationID = -1;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                            VALUES (@ApplicationID, @LicenseClassID)
                            SELECT SCOPE_IDENTITY();";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();

                        var result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out var insertedID))
                            LocalDrivingLicenseApplicationID = insertedID;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int? LocalDrivingLicenseApplicationID,
            int ApplicationID, int LicenseClassID)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"UPDATE LocalDrivingLicenseApplications  
                            SET 
                            ApplicationID = @ApplicationID, 
                            LicenseClassID = @LicenseClassID
                            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                            LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        public static bool DeleteLocalDrivingLicenseApplication(int? LocalDrivingLicenseApplicationID)
        {
            var rowsAffected = 0;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = @"Delete LocalDrivingLicenseApplications 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                            (object)LocalDrivingLicenseApplicationID ?? DBNull.Value);

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

        public static bool DoesLocalDrivingLicenseApplicationExist(int? LocalDrivingLicenseApplicationID)
        {
            var isFound = false;

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query =
                        "SELECT Found = 1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",
                            (object)LocalDrivingLicenseApplicationID ?? DBNull.Value);

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

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM LocalDrivingLicenseApplications";

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

        public static DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            var dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString))
                {
                    var query = "SELECT * FROM LDLApplications_View";

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

        public static DataTable GetFilterdLDLRecords(string FilterName, string Value)
        {
            var dt = new DataTable();
            var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString);
            var query = "SELECT * FROM LDLApplications_View  WHERE " + FilterName + " LIKE '%" + Value + "%'";
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

        public static DataTable GetLDLByApplicationDate(DateTime startDate, DateTime endDate)
        {
            var dt = new DataTable();
            var connection = new SqlConnection(DataAccesLayerSettings.ConnectionString);
            var query =
                "SELECT  *  FROM LDLApplications_View WHERE ApplicationDate >= @StartDate AND ApplicationDate <= @EndDate ";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
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
    }
}