using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDataAccrssLayer.Properties
{
    public class ReservationsDAO
    {
        public static bool GetReservationInfoByID(int ReservationID, ref int UserID, ref int CopyID, ref DateTime ReservationDate)
{
	bool isFound = false;

	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID";
	SqlCommand command = new SqlCommand(query, connection);
	command.Parameters.AddWithValue("@ReservationID", ReservationID);

	try
	{

		connection.Open();
		SqlDataReader reader = command.ExecuteReader();

		if (reader.Read())
		{
			isFound = true;

			ReservationID = (int)reader["ReservationID"];
			UserID = (int)reader["UserID"];
			CopyID = (int)reader["CopyID"];
			ReservationDate = (DateTime)reader["ReservationDate"];

		}
		else
		{
			isFound = false;
		}

		reader.Close();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }

	return isFound;

}
		public static int AddNewReservation( int UserID,  int CopyID,  DateTime ReservationDate){

        int ID = -1;

	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        string query = @"INSERT INTO Reservations VALUES (@UserID, @CopyID, @ReservationDate)
        SELECT SCOPE_IDENTITY()";

	SqlCommand command = new SqlCommand(query, connection);


	command.Parameters.AddWithValue("@UserID", UserID );

	command.Parameters.AddWithValue("@CopyID", CopyID );

	command.Parameters.AddWithValue("@ReservationDate", ReservationDate );


                    try
            {
                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine(Error:  + ex.Message);
               
            }

            finally 
            {
                connection.Close(); 
            }


            return ID;

}
		public static bool UpdateReservation( int ReservationID,  int UserID,  int CopyID,  DateTime ReservationDate)
{
	int rowsAffected=0;

	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

	string query = @"UPDATE Reservations
	SET	UserID = @UserID,
	CopyID = @CopyID,
	ReservationDate = @ReservationDate	WHERE ReservationID = @ReservationID";

	SqlCommand command = new SqlCommand(query, connection);


	command.Parameters.AddWithValue("@ReservationID", ReservationID );

	command.Parameters.AddWithValue("@UserID", UserID );

	command.Parameters.AddWithValue("@CopyID", CopyID );

	command.Parameters.AddWithValue("@ReservationDate", ReservationDate );


	try {connection.Open(); rowsAffected = command.ExecuteNonQuery();}
	catch (Exception ex) {}
	finally{ connection.Close(); }

	return (rowsAffected > 0);

}
	    public static bool DeleteReservation(int ReservationID)
{
	int rowsAffected = 0;
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "DELETE Reservations WHERE ReservationID = @ReservationID";
	SqlCommand command = new SqlCommand(query, connection);

	command.Parameters.AddWithValue("@ReservationID", ReservationID );

	try
	{
		connection.Open();
		rowsAffected = command.ExecuteNonQuery();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }


	return (rowsAffected > 0);

}

		public static bool IsReservationExist(int ReservationID)
{
	bool isFound = false;
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT Found=1 FROM Reservations WHERE ReservationID= @ReservationID"; 
	SqlCommand command = new SqlCommand(query, connection);

	command.Parameters.AddWithValue("@ReservationID", ReservationID );

	try
	{
		connection.Open();
		SqlDataReader reader = command.ExecuteReader();
		isFound = reader.HasRows;
		reader.Close();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }


	return isFound;

}

		public static DataTable GetAllReservations()
{

	DataTable dt = new DataTable();
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM Reservations";
	SqlCommand command = new SqlCommand(query, connection);

	try
	{
		connection.Open();
		SqlDataReader reader = command.ExecuteReader();
		if (reader.HasRows)dt.Load(reader);
		reader.Close();
	}
	catch (Exception ex) {}
	finally{ connection.Close(); }


	return dt;
}

public static DataTable GetReservationsByUserID(int UserID)
{
	DataTable dt = new DataTable();
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM Reservations WHERE UserID=@UserID";
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

public static DataTable GetReservationsByCopyID(int CopyID)
{
	DataTable dt = new DataTable();
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT * FROM Reservations WHERE CopyID=@CopyID";
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

public static DataTable GetReservationsByDate(DateTime ReservationDate)
{
	DataTable dt = new DataTable();
    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
    string query = "SELECT * FROM Reservations WHERE ReservationDate=@ReservationDate";
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.AddWithValue("@ReservationDate", ReservationDate);
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

public static bool CheckIfBookCopyIsReserved(int CopyID)
{
	bool isBorrowed = false;
	DataTable dt = new DataTable();
	SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
	string query = "SELECT Found=1 FROM Reservations WHERE CopyID=@CopyID";
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

}



    
}