using System;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer
{
    public class SettingsDAO
    {
        public static bool DefualtBorrrowDays( ref int DefualtBorrrowDays )
        {
            bool Result=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT DefualtBorrrowDays FROM Settings ";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object  result = command.ExecuteScalar();
                if (result!= null && int.TryParse(result.ToString(), out int fetchedDefualtBorrrowDays))
                {
                    DefualtBorrrowDays = fetchedDefualtBorrrowDays;
                    Result= true;
                }
                else
                {
                    Result= false;
                }
               

            }
            catch (Exception e)
            {
                Result= false;
            }
            finally
            {
                connection.Close();
            }
            return Result;

        }
        public static bool GetDefaultFinePerDay(ref int DefaultFinePerDay )
        {
            bool ret = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT DefaultFinePerDay FROM Settings ";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result!= null && int.TryParse(result.ToString(), out int fetchedDefualtBorrrowDays))
                {
                    DefaultFinePerDay = fetchedDefualtBorrrowDays;
                    ret= true;
                }
               

            }
            catch (Exception e)
            {
                ret= false;
            }
            finally
            {
                connection.Close();
            }
            return ret;

        }
        public static bool  UpdateDefaultBorrowDays(int DefaultBorrowDays)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                int rowsAffected = 0;
                string query = "UPDATE Settings SET DefualtBorrrowDays = @DefaultBorrowDays;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DefaultBorrowDays", DefaultBorrowDays);
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
        }
        
        public static  bool UpdateDefaultFinePerDay(int DefaultFinePerDay)
        {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                int rowsAffected = 0;
                string query = "UPDATE Settings SET DefaultFinePerDay = @DefaultFinePerDay;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DefaultFinePerDay", DefaultFinePerDay);
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
        }
        
        public static bool ExtendedBorrowDays( ref int ExtendedBorrowDays )
        {
            bool Result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT ExtendedBorrowDays FROM Settings ";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                Object result= command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    Result=true;
                    ExtendedBorrowDays = insertedID;
                }
  

            }
            catch (Exception e)
            {
                Result= false;
            }
            finally
            {
                connection.Close();
            }
            return Result;

        }

        public static bool UpdateExtendedBorrowDays(int ExtendedBorrowDays)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int rowsAffected = 0;
            string query = "UPDATE Settings SET ExtendedBorrowDays = @ExtendedBorrowDays;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ExtendedBorrowDays", ExtendedBorrowDays);
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

        public static bool LateFineByDay(ref int LateFineByDay)
        {
            bool Result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT LateFinePerDay FROM Settings ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int fetchedLateFineByDay))
                {
                    Result = true;
                    LateFineByDay = fetchedLateFineByDay;
                }

            }
            catch (Exception e)
            {
                Result = false;
            }
            finally
            {
                connection.Close();
            }
            return Result;
        }

        public static bool UpdateLateFineByDay(int LateFinePerDay)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int rowsAffected = 0;
            string query = "UPDATE Settings SET LateFinePerDay = @LateFinePerDay;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LateFinePerDay", LateFinePerDay);
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

    }
    }