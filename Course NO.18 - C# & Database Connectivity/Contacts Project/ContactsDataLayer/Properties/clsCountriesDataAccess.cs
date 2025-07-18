using System;
using System.Data;
using System.Data.SqlClient;

namespace ContactsDataLayer.Properties
{
    public class clsCountriesDataAccess
    {
        public static bool IsExist(string countryName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT Found=1 FROM Countries WHERE CountryName=@countryName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countryName", countryName);
            bool isExist = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isExist = reader.HasRows;
                reader.Close();
                

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static bool IsExist(int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT Found=1 FROM Countries WHERE CountryID=@CountryID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            bool isExist = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isExist = reader.HasRows;
                reader.Close();
                

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return isExist;
        }
        public static bool FindCountryById(int id, ref string countryName)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT CountryName FROM Countries WHERE CountryID=@id";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    countryName = reader["CountryName"].ToString();
                    isfound = true;
                }
                else
                {
                    isfound = false;
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

            return isfound;

        }

        public static bool FindCountryByName(string CountryName, ref int id)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT CountryID FROM Countries WHERE CountryName=@countryName";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["CountryID"]);
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

            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static int AddCountry(string countryName)
        {
            int CountryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "INSERT INTO Countries (CountryName) VALUES (@countryName) SELECT SCOPE_IDENTITY()";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countryName", countryName);
            try
            {
                connection.Open();
                Object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    CountryID = ID;
                }
                else
                {
                    CountryID = -1;
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return CountryID;
        }

        public static bool UpdateCountry(int ID, string countryName)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "UPDATE Countries SET CountryName=@countryName WHERE CountryID=@id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countryName", countryName);
            cmd.Parameters.AddWithValue("@id", ID);
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {

            }

            return (rowsAffected > 0);

        }

        public static bool DeleteCountry(string name)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "DELETE FROM Countries WHERE CountryName=@name";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

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

        public static bool DeleteCountry(int name)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "DELETE FROM Countries WHERE CountryName=@name";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@name", name);
            int rowsAffected = 0;
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

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

        public static DataTable ListCountries()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Countries";
            SqlCommand command = new SqlCommand(query, connection);
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = (command.ExecuteReader());
                if (reader.HasRows)
                {
                    table.Load(reader);
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

            return table;
        }

    }
}