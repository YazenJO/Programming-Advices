using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer
{
    public class BorrowingRecordDAO
    {
        public static bool GetBorrowingRecordById(int ID,ref int UserID,ref int CopyID,
            ref DateTime BorrowingDate,ref DateTime DueDate,ref DateTime? ActualReturnDate)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BorrowingRecords WHERE BorrowingRecordID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    UserID = (int)reader["UserID"];
                    CopyID = (int)reader["CopyID"];
                    BorrowingDate = (DateTime)reader["BorrowingDate"];
                   
                    DueDate = (DateTime)reader["DueDate"];
                    if (reader["ActualReturnDate"]==DBNull.Value)
                    {
                        ActualReturnDate = null;
                    }
                    else
                    {
                        ActualReturnDate = (DateTime)reader["ActualReturnDate"];
                    }

                }
                else
                {
                    isfound= false;
                }

            }
            catch (Exception e)
            {
                isfound= false;
            }
            finally
            {
                connection.Close();
            }
            return isfound;

        }

        public static bool DoesUserHaveBorrowingRecord(int UserID)
        {
            bool isBorrowed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isBorrowed=reader.HasRows;
                reader.Close();

            }
            catch (Exception e)
            {
                isBorrowed=false;
            }
            finally
            {
                connection.Close();
            }
            return isBorrowed;
        }
        public static int AddNewBorrowingRecord(int UserID, int CopyID, DateTime BorrowingDate, DateTime DueDat,DateTime? ActualReturnDate)
        {
            int BorrowRecordID =-1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO BorrowingRecords (UserID, CopyID,DueDate ,BorrowingDate,ActualReturnDate) VALUES (@UserID, @CopyID,@DueTime ,@BorrowingDate,@ActualReturnDate); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
          
           
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@ActualReturnDate", (object)ActualReturnDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@DueTime", DueDat);
         
           

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result!= null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BorrowRecordID = insertedID;
                }

            }
            catch (Exception e)
            {
               
            }
            finally
            {
                connection.Close();
            }

            
            return (BorrowRecordID) ;
            
        }

        public static bool UpdateBorrowingRecord(int ID, int UserID, int CopyID, DateTime BorrowingDate,
            DateTime DueDat, DateTime? ActualReturnDate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE BorrowingRecords SET UserID=@UserID, CopyID=@CopyID, BorrowingDate=@BorrowingDate, DueDate=@DueDate, ActualReturnDate=@ActualReturnDate WHERE BorrowingRecordID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
            command.Parameters.AddWithValue("@DueDate", DueDat);
            command.Parameters.AddWithValue("@ActualReturnDate", (object)ActualReturnDate ?? DBNull.Value);

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

        public static bool DeleteBorrowingRecord(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM BorrowingRecords WHERE BorrowingRecordID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
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

        public static DataTable GetAllBorrowingRecords()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BooksBorrowsView ORDER BY BorrowingRecordID DESC";
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

        public static DataTable GetBorrowingRecordsByUserId(int UserID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BorrowingRecords WHERE UserID=@UserID";
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

        public static DataTable GetBorrowingRecordsByCopyId(int CopyID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BorrowingRecords WHERE CopyID=@CopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
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

        public static int GetUserIdByBorrowId(int BorrrowID)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT UserID FROM BorrowingRecords WHERE BorrowingRecordID=@ID";
            SqlCommand command = new SqlCommand(query, connection); 
            command.Parameters.AddWithValue("@ID", BorrrowID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int userID))
                {
                    UserID = userID;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return UserID;
        }

        public static int GetCopyIDByBorrowId(int BorrrowID)
        {
            
            int CopyID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT CopyID FROM BorrowingRecords WHERE BorrowingRecordID=@ID";
            SqlCommand command = new SqlCommand(query, connection); 
            command.Parameters.AddWithValue("@ID", BorrrowID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int CPYID))
                {
                    CopyID = CPYID;
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

        public static DataTable GetOverdueBorrowingRecords()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BooksBorrowsView br WHERE br.DueDate < CAST(GETDATE() AS DATE);";
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

        public static DataTable GetOnTimeBorrowingRecords()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BooksBorrowsView br WHERE br.BorrowingDate < =DueDate;";
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

        public static DataTable GetBorrowingRecordsByDate(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BooksBorrowsView br WHERE br.BorrowingDate >= @StartDate AND br.BorrowingDate <= @EndDate;";
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

        public static bool ReturnBook(int BorrowingRecordID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE BorrowingRecords SET ActualReturnDate=CAST(GETDATE() AS DATE) WHERE BorrowingRecordID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", BorrowingRecordID);
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
        
        

        public static bool CheckIfBookIsBorrowed(int CopyID)
        {
            bool isBorrowed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM BorrowingRecords WHERE CopyID=@CopyID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CopyID", CopyID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isBorrowed=reader.HasRows;
                reader.Close();

            }
            catch (Exception e)
            {
                isBorrowed=false;
            }
            finally
            {
                connection.Close();
            }
            return isBorrowed;
        }

        public static int CalculateBorrowDays(int BorrowID)
        {
            int DiffrenceDays = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT DATEDIFF(DAY, br.BorrowingDate, GETDATE()) AS DaysLate FROM BorrowingRecords br WHERE br.BorrowingRecordID = @BorrowingRecordID";
            SqlCommand command = new SqlCommand(query, connection); 
            command.Parameters.AddWithValue("@BorrowingRecordID", BorrowID);
            try
            {
                connection.Open();
                Object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int Diiffrence))
                {

                    DiffrenceDays = Diiffrence;
                }




            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }
            return DiffrenceDays;
            
            
        }

        public static bool ExtentdBorrow(int BorrowID,int NumberOFDays)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE BorrowingRecords SET DueDate=DATEADD(DAY, @NumberOFDays, DueDate) WHERE BorrowingRecordID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", BorrowID);
            command.Parameters.AddWithValue("@NumberOFDays", NumberOFDays);
            
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

        public class BorrowViewDAO
        {
           
            public static bool GetBorrowingViewRecordById(int BorrowingRecordID, ref string UserName
                , ref string BookTitle, ref string Genre, ref string BookISBN, ref DateTime BorrowingDate,
                ref DateTime DueDate, ref DateTime? ActualReturnDate, ref bool AvailabilityStatus,
                ref bool? PaymentStatus)
            {
                bool isfound = false;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = "SELECT * FROM BooksBorrowsView where BorrowingRecordID=@BorrowingRecordID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        UserName = reader["Name"].ToString();
                        BookTitle = reader["Title"].ToString();
                        Genre = reader["Genre"].ToString();
                        BookISBN = reader["ISBN"].ToString();
                        BorrowingDate = Convert.ToDateTime(reader["BorrowingDate"]);
                        DueDate = Convert.ToDateTime(reader["DueDate"]);
                        ActualReturnDate = reader["ActualReturnDate"] is DBNull
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["ActualReturnDate"]);
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"]);
                        PaymentStatus = reader["PaymentStatus"] is DBNull? (bool?)null: Convert.ToBoolean(reader["PaymentStatus"]);
                        isfound = true;
                    }

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

            public static bool UpdateBorrowningRecord(int BorrowingRecordID, string UserName, string BookTitle,
                string Genre, string BookISBN, DateTime BorrowingDate,
                DateTime DueDate, DateTime? ActualReturnDate, bool AvailabilityStatus, bool? PaymentStatu)
            {
                int rowsAffected = 0;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
                string query = @"UPDATE BooksBorrowsView SET Name=@UserName, Title=@BookTitle, Genre=@Genre, ISBN=@BookISBN, " +
                    "BorrowingDate=@BorrowingDate, DueDate=@DueDate, ActualReturnDate=@ActualReturnDate, AvailabilityStatus=@AvailabilityStatus, PaymentStatus=@PaymentStatus WHERE BorrowingRecordID=@BorrowingRecordID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BorrowingRecordID", BorrowingRecordID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@BookTitle", BookTitle);
                command.Parameters.AddWithValue("@Genre", Genre);
                command.Parameters.AddWithValue("@BookISBN", BookISBN);
                command.Parameters.AddWithValue("@BorrowingDate", BorrowingDate);
                command.Parameters.AddWithValue("@DueDate", DueDate);
                command.Parameters.AddWithValue("@ActualReturnDate", (object)ActualReturnDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@AvailabilityStatus", AvailabilityStatus);
                command.Parameters.AddWithValue("@PaymentStatus", (object)ActualReturnDate ?? DBNull.Value);
               
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
                
                return (rowsAffected>0);
                
            }
            
          
            
        }
       
        
        

      


    }
}