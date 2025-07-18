using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer
{
    public class BooksData
    {
        public static bool GetBookInfoByID(int ID, ref string Title, ref string ISBN,
            ref DateTime PublicationDate, ref string Genre, ref string AdditionalDetails, 
            ref string Authorname, ref string Language, ref int Copies)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Books WHERE BookID = @BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    Title = reader["Title"].ToString();
                    ISBN = reader["ISBN"].ToString();
                    PublicationDate = (DateTime)reader["PublicationDate"];
                    Genre = reader["Genre"].ToString();
                    AdditionalDetails = reader["AdditionalDetails"].ToString();
                    Authorname = reader["Authorname"].ToString();
                    Language = reader["Language"].ToString();
                    Copies = (int)reader["Copies"];

                    
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

        public static bool GetBookInfoByName(string name,
        ref int ID, ref string ISBN,
        ref DateTime PublicationDate, ref string Genre, ref string AdditionalDetails, 
        ref string Authorname, ref string Language, ref int Copies)
        {
            
            bool isFound = false;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Books WHERE Title = @Title";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", name);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["BookID"];
                    ISBN = reader["ISBN"].ToString();
                    PublicationDate = (DateTime)reader["PublicationDate"];
                    Genre = reader["Genre"].ToString();
                    AdditionalDetails = reader["AdditionalDetails"].ToString();
                    Authorname = reader["Authorname"].ToString();
                    Language = reader["Language"].ToString();
                    Copies = (int)reader["Copies"];
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

            return isFound;
        }


        public static int AddNewBook(string Title, string ISBN, DateTime PublicationDate, string Genre, string AdditionalDetails, string Authorname, string Language, int Copies)
        {
            int BookId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query =
                @"INSERT INTO Books (Title, ISBN, PublicationDate, Genre, AdditionalDetails, Authorname, Language, Copies) 
          VALUES (@Title, @ISBN, @PublicationDate, @Genre, @AdditionalDetails, @Authorname, @Language, @Copies);
          SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
            command.Parameters.AddWithValue("@Authorname", Authorname);
            command.Parameters.AddWithValue("@Language", Language);
            command.Parameters.AddWithValue("@Copies", Copies);

           

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BookId = insertedID;
                }
            }
            catch (Exception e)
            {
                // Handle exception properly
            }
            finally
            {
                connection.Close();
            }

            return BookId;
        }


        public static bool UpdateBook(int ID, string Title, string ISBN, DateTime PublicationDate, string Genre,
            string AdditionalDetails, string Authorname, string Language, int Copies)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query =
                @"UPDATE Books 
          SET Title=@Title, ISBN=@ISBN, PublicationDate=@PublicationDate, Genre=@Genre, 
              AdditionalDetails=@AdditionalDetails, 
              Authorname=@Authorname, Language=@Language, Copies=@Copies 
          WHERE BookID=@BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", ID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
            command.Parameters.AddWithValue("@Genre", Genre);
            command.Parameters.AddWithValue("@AdditionalDetails", AdditionalDetails);
            command.Parameters.AddWithValue("@Authorname", Authorname);
            command.Parameters.AddWithValue("@Language", Language);
            command.Parameters.AddWithValue("@Copies", Copies);

          

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


        public static bool DeleteBook(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Books WHERE BookID=@BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", ID);
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

        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Books";
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

        public static bool IsBookExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT Found=1 FROM Books WHERE BookID=@BookID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BookID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                reader.Close();

            }
            catch (Exception e)
            {
                isExist = false;
            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static DataTable GetFilterdBooks(string FilterName, string Value)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM BooksBorrowsView WHERE " + FilterName + " LIKE '%" + Value + "%'";
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
        
        public static DataTable GetBookByLanguage(string Value)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Books WHERE Language" + " LIKE '%" + Value + "%'";
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
        
        public static DataTable GetBooksByPublishDateDate(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Books br WHERE PublicationDate >= @StartDate AND PublicationDate <= @EndDate;";
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







