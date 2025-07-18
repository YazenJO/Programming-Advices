using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer
{
    public class BookCopiesDAO
    {
        
        public static bool GetCopyByID(int CopyID, ref int BookID, ref bool AvailabilityStatus)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM BookCopies WHERE CopyID = @CopyID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", (object)CopyID ?? DBNull.Value);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                BookID = (int)reader["BookID"];
                                AvailabilityStatus = (bool)reader["AvailabilityStatus"];
                            }
                            else
                                isFound = false;
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
        public static int AddNewCopy(int BookID, bool AvailabilityStatus)
        {
            int CopyID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO BookCopies (BookID, AvailabilityStatus)
                            VALUES (@BookID, @AvailabilityStatus)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            CopyID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return CopyID;
        }
        public static bool UpdateCopy(int CopyID, int BookID, bool AvailabilityStatus)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE BookCopies  
                            SET 
                            BookID = @BookID, 
                            AvailabilityStatus = @AvailabilityStatus
                            WHERE CopyID = @CopyID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CopyID", CopyID);
                        command.Parameters.AddWithValue("@BookID", BookID);
                        command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }

            return (rowsAffected > 0);
        }
        public static bool DeleteCopy(int CopyID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete BookCopies 
                                where CopyID = @CopyID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", (object)CopyID ?? DBNull.Value);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }

            }
            catch(Exception ex)
            {

            }

            return (rowsAffected > 0);
        }
        public static bool DoesCopyExist(int CopyID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM BookCopies WHERE CopyID = @CopyID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CopyID", (object)CopyID  ?? DBNull.Value);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        isFound = reader.HasRows;
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
            }

            return isFound;
        }
        public static DataTable GetAllBookCopies()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM BookCopies";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if(reader.HasRows)
                            dt.Load(reader);
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return dt;
        }
    

        public static bool IsBookCopied(int BookID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM BookCopies WHERE BookID=@BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();


            }
            catch (Exception e)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool AvailabilityStatus(int CopyID)
        {
            bool isAvailable = false;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT AvailabilityStatus FROM BookCopies WHERE CopyID=@CopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                    isAvailable = (bool)reader["AvailabilityStatus"];
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
            return isAvailable;
        }

        public static DataTable GetAvailabilCopies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT *FROM BooksBorrowsView WHERE AvailabilityStatus=1";
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
        
        public static DataTable GetNotAvailabilCopies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BooksBorrowsView WHERE AvailabilityStatus=0";
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

        public static bool MarkCopyIDAsAvailabil(int CopyID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE BookCopies SET AvailabilityStatus=1 WHERE CopyID=@CopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
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

        private static int GetCopyIDFromTheBorrowingID(int BorrowingID)
        {
             int CopyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CopyID FROM BorrowingRecords WHERE BorrowingRecordID=@BorrowingID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int CopyIdr))
                {
                    CopyID = CopyIdr;
                   
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return CopyID;
        }

        public static bool MarkCopyAsAvailabilByBorrowID(int BorrowID)
        {
                
            return MarkCopyIDAsAvailabil(GetCopyIDFromTheBorrowingID(BorrowID));
        }

        public static bool MarkCopyIDAsNotAvailabil(int CopyID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE BookCopies SET AvailabilityStatus=0 WHERE CopyID=@CopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
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

        public static int GetAvailableCopyOFTheBook(int BookID)
        {
            int copyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TOP 1 bc.CopyID FROM BookCopies bc WHERE bc.BookID = @BookID AND bc.AvailabilityStatus = 1 ORDER BY bc.CopyID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            try
            {
                connection.Open();
                Object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    copyID = insertedID;
                }
                
              

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return copyID;
        }

        public static bool GetNumberOFAvailableCopyOfBook(int BookID,ref int NumberOfCopies)
        {
            bool isAvailable = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT count(*) FROM BookCopies bc WHERE bc.BookID=@BookID AND bc.AvailabilityStatus=1";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result!= null && int.TryParse(result.ToString(), out int NofCopies))
                {
                    isAvailable = true;
                    NumberOfCopies = NofCopies;

                }
                else
                {
                    isAvailable = false;
                    
                }


            }
            catch (Exception e)
            {
                isAvailable = false;
            }
            finally
            {
                connection.Close();
            }
            return isAvailable;
        }

        public static bool IsCopyAvailable(int CopyID)
        {
            bool isAvailable = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT AvailabilityStatus FROM BookCopies WHERE CopyID=@CopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result!= null && bool.TryParse(result.ToString(), out bool isAvl))
                {
                    isAvailable = isAvl;
                }


            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return isAvailable;
        }

    }
}