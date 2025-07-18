using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer
{
    public class PaymentsDAO
    {
        public static bool GetPaymentByID(int PaymentID, ref int ReaderID, ref DateTime PaymymentDate, ref decimal PaymentAmount, ref int UserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;


                                ReaderID = (int)reader["ReaderID"];
                                PaymymentDate = (DateTime)reader["PaymymentDate"];
                                PaymentAmount = (decimal)reader["PaymentAmount"];
                                UserID = (int)reader["UserID"];
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
        public static int AddNewPayment(int ReaderID, DateTime PaymymentDate, decimal PaymentAmount, int UserID)
        {
            int PaymentID = -1;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO Payments (ReaderID, PaymymentDate, PaymentAmount, UserID)
                            VALUES (@ReaderID, @PaymymentDate, @PaymentAmount, @UserID)
                            SELECT SCOPE_IDENTITY();";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
                        command.Parameters.AddWithValue("@PaymymentDate", PaymymentDate);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(), out int insertedID))
                            PaymentID = insertedID;
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return PaymentID;
        }
        public static bool UpdatePayment(int PaymentID, int ReaderID, DateTime PaymymentDate, decimal PaymentAmount, int UserID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE Payments  
                            SET 
                            ReaderID = @ReaderID, 
                            PaymymentDate = @PaymymentDate, 
                            PaymentAmount = @PaymentAmount, 
                            UserID = @UserID
                            WHERE PaymentID = @PaymentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@ReaderID", ReaderID);
                        command.Parameters.AddWithValue("@PaymymentDate", PaymymentDate);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("@UserID", UserID);

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
        public static bool DeletePayment(int PaymentID)
        {
            int rowsAffected = 0;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete Payments 
                                where PaymentID = @PaymentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);

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
        public static bool DoesPaymentExist(int? PaymentID)
        {
            bool isFound = false;

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT Found = 1 FROM Payments WHERE PaymentID = @PaymentID";

                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PaymentID",PaymentID);

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
        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM PaymentsView";

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
        public static DataTable GetFilterdPayments(string FilterName, string Value)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM PaymentsView WHERE " + FilterName + " LIKE '%" + Value + "%'";
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
        
        public static DataTable GetPaymentsByBirthDateDate(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT  *  FROM PaymentsView WHERE PaymymentDate >= @StartDate AND PaymymentDate <= @EndDate ";
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

    }
}