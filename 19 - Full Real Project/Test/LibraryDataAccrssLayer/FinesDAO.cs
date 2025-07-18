using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer
{
    public class FinesDAO
    {
        public static bool GetFineInfoByID(int FineId, ref int UserID, ref int BorrowingRecordID,
            ref int NumberOfLateDayes
            , ref decimal FineAmount, ref bool PaymentStatus)
        {
            bool isFound = false;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines WHERE FineID=@FineID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FineID", FineId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    BorrowingRecordID = (int)reader["BorrowingRecordID"];
                    NumberOfLateDayes = (int)reader["NumberOfLateDays"];
                    FineAmount = (decimal)reader["FineAmount"];
                    PaymentStatus = (bool)reader["PaymentStatus"];
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }

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

        public static int AddNewFine(int UserID, int BorrowingRecordID, int NumberOfLateDays, decimal FineAmount,
            bool PaymentStatus)
        {
            int FineID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Fines (UserID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus) VALUES (@UserID, @BorrowingRecordID, @NumberOfLateDays, @FineAmount, @PaymentStatus); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@FineAmount", FineAmount);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    FineID = insertedID;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return FineID;
        }

        public static bool UpdateFine(int FineID, int UserID, int BorrowingRecordID, int NumberOfLateDays,
            decimal FineAmount, bool PaymentStatus)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"UPDATE Fines SET UserID=@UserID, BorrowingRecordID=@BorrowingRecordID, NumberOfLateDays=@NumberOfLateDays, FineAmount=@FineAmount, PaymentStatus=@PaymentStatus WHERE FineID=@FineID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FineID", FineID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("@NumberOfLateDays", NumberOfLateDays);
            command.Parameters.AddWithValue("@FineAmount", FineAmount);
            command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
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

        public static bool DeleteFine(int FineID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Fines WHERE FineID=@FineID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FineID", FineID);
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

        public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines";
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

        public static bool IsFineExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Fines WHERE FineID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                reader.Close();


            }
            catch (Exception e)
            {
                isExist=false;
            }
            finally
            {
                connection.Close();
            }
            return isExist;
        }

        public static DataTable GetFineByUser(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines WHERE UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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

        public static DataTable GetFineByBorrowingRecordId(int BorrowingRecordID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines WHERE BorrowingRecordID=@BorrowingRecordID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
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

        public static DataTable GetUnpaidFines()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines WHERE PaymentStatus=0";
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

        public static DataTable GetpaidFines()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines WHERE PaymentStatus=1";
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

        public static bool MarkFineAsPaid(int FineID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Fines SET PaymentStatus=1 WHERE FineID=@FineID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FineID", FineID);
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

        public static bool MarkFineAsUnPaid(int FineID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Fines SET PaymentStatus=0 WHERE FineID=@FineID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FineID", FineID);
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
        

        public static bool GetFineInfoByBorrowID( int BorrowingRecordID, ref int UserID, ref int FineId,
            ref int NumberOfLateDayes
            , ref decimal FineAmount, ref bool PaymentStatus)
        {
            bool isFound = false;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Fines WHERE BorrowingRecordID=@BorrowingRecordID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    FineId = (int)reader["FineID"];
                    NumberOfLateDayes = (int)reader["NumberOfLateDays"];
                    FineAmount = (decimal)reader["FineAmount"];
                    PaymentStatus = (bool)reader["PaymentStatus"];
                    isFound = true;
                }
                else
                {
                    isFound = false;
                }

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
        
        
        
     
        
        
        
            

    }
}