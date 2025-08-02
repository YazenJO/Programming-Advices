using System;
using System.Data;
using System.Linq;
namespace DataTable_Example_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataTable Custmers = new DataTable("Customers");

            // Add columns to the data table
            Custmers.Columns.Add("CustomerID", typeof(int));
            Custmers.Columns.Add("CustomerName", typeof(string));
            Custmers.Columns.Add("ContactName", typeof(string));
            Custmers.Columns.Add("Address", typeof(string));
            Custmers.Columns.Add("City", typeof(string));
            Custmers.Columns.Add("PostalCode", typeof(string));
            Custmers.Columns.Add("Country", typeof(string));
            Custmers.Columns.Add("Salary", typeof(int));

            // Add data to the data table
            Custmers.Rows.Add(1, "ALFKI", "Andrew", "Obere Str. 57", "Berlin", "12209", "Germany", 5000);
            Custmers.Rows.Add(2, "ANATR", "Angie", "Avda. de la Constitución 2222", "México D.F.", "05021", "Mexico",
                1000);
            Custmers.Rows.Add(3, "AROUT", "Alfred", "123 Maple Street", "Boston", "02114", "USA", 3333);
            Custmers.Rows.Add(4, "BERGS", "Bertrand", "Baker Boulevard 123", "London", "SW1 8JR", "UK", 200);
            Custmers.Rows.Add(5, "BLAUS", "Christina", "Forsterstr. 424", "Mannheim", "68306", "Germany", 800);
            Custmers.Rows.Add(6, "BLONP", "Francisca", "Boulevard de la Grande-Parisienne 123", "Marseille", "13008",
                "France", 1000);

            Console.WriteLine(
                "\t _________________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------ ");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|", "ID",
                "CustomerName", "ContactName", "Address", "City Of Birth", "PostalCode", "Country", "Salary");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");

            foreach (DataRow row in Custmers.Rows)
            {
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|",
                    row["CustomerID"], row["CustomerName"], row["ContactName"], row["Address"], row["City"],
                    row["PostalCode"], row["Country"], row["Salary"]);
                Console.WriteLine(
                    "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");
            }

            //------------------------------------------------------------------------------------------------Example 1 End :)
            int CustmersCount = 0;
            double TotalSalaries = 0;
            double AverageSalaries = 0;
            double MinSalary = 0;
            double MaxSalary = 0;
            CustmersCount = Custmers.Rows.Count;
            TotalSalaries = Convert.ToDouble(Custmers.Compute("SUM(Salary)", string.Empty));
            AverageSalaries = Convert.ToDouble(Custmers.Compute("AVG(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(Custmers.Compute("MIN(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(Custmers.Compute("MAX(Salary)", string.Empty));
            Console.WriteLine("\n\tTotal Customers: {0}", CustmersCount);
            Console.WriteLine("\tTotal Salaries: {0:C}", TotalSalaries);
            Console.WriteLine("\tAverage Salaries: {0:C}", AverageSalaries);
            Console.WriteLine("\tMinimum Salary: {0:C}", MinSalary);
            Console.WriteLine("\tMaximum Salary: {0:C}", MaxSalary);
            //------------------------------------------------------------------------------------------------Example 2 End :)
            DataRow[] DataRow = Custmers.Select("Country='Germany'");
            Console.WriteLine("\n\tGerman Customers:");
            foreach (DataRow row in DataRow)
            {
                Console.WriteLine("\tID: {0}, Name: {1}, Salary: {2:C}", row["CustomerID"], row["CustomerName"],
                    row["Salary"]);
            }

            CustmersCount = DataRow.Length;
            TotalSalaries = Convert.ToDouble(Custmers.Compute("SUM(Salary)", "Country='Germany'"));
            AverageSalaries = Convert.ToDouble(Custmers.Compute("AVG(Salary)", "Country='Germany'"));
            MinSalary = Convert.ToDouble(Custmers.Compute("MIN(Salary)", "Country='Germany'"));
            MaxSalary = Convert.ToDouble(Custmers.Compute("MAX(Salary)", "Country='Germany'"));
            Console.WriteLine("\n\tTotal Customers in Germany: {0}", CustmersCount);
            Console.WriteLine("\tTotal Salaries of German Customers: {0:C}", TotalSalaries);
            Console.WriteLine("\tAverage Salaries of German Customers: {0:C}", AverageSalaries);
            Console.WriteLine("\tMinimum Salary of German Customers: {0:C}", MinSalary);
            Console.WriteLine("\tMaximum Salary of German Customers: {0:C}", MaxSalary);

            //------------------------------------------------------------------------------------------------Example 3 End :)
            Custmers.DefaultView.Sort = "CustomerName ASC";
            Custmers = Custmers.DefaultView.ToTable();
            Console.WriteLine(
                "\t _________________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------ ");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|", "ID",
                "CustomerName", "ContactName", "Address", "City Of Birth", "PostalCode", "Country", "Salary");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");

            foreach (DataRow row in Custmers.Rows)
            {
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|",
                    row["CustomerID"], row["CustomerName"], row["ContactName"], row["Address"], row["City"],
                    row["PostalCode"], row["Country"], row["Salary"]);
                Console.WriteLine(
                    "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");
            }

            //------------------------------------------------------------------------------------------------Example 4 End :)
            Console.WriteLine("\n\n\nAfter Delete Customer With ID 4 ");
            DataRow[] Result = Custmers.Select("CustomerID=4");
            foreach (var RecordRow in Result)
            {
                RecordRow.Delete();
            }

            Console.WriteLine(
                "\t _________________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------ ");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|", "ID",
                "CustomerName", "ContactName", "Address", "City Of Birth", "PostalCode", "Country", "Salary");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");

            foreach (DataRow row in Custmers.Rows)
            {
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|",
                    row["CustomerID"], row["CustomerName"], row["ContactName"], row["Address"], row["City"],
                    row["PostalCode"], row["Country"], row["Salary"]);
                Console.WriteLine(
                    "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");
            }

            //------------------------------------------------------------------------------------------------Example 5 End :)
            Console.WriteLine("\n\n\nAfter Update Customer With ID 1 ");
            DataRow[] Update = Custmers.Select("CustomerID=1");
            foreach (var RecordRow in Update)
            {


                RecordRow["CustomerName"] = "Abo Yasser";
                RecordRow["ContactName"] = "M3LM Shawrma";
                RecordRow["Address"] = "Jordan";
                RecordRow["City"] = "Amman";
                RecordRow["PostalCode"] = "11511";
                RecordRow["Salary"] = "-1";

            }

            Console.WriteLine(
                "\t _________________________________________________________________________________________________________________________________________________________________________________________________________");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------ ");
            Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|", "ID",
                "CustomerName", "ContactName", "Address", "City Of Birth", "PostalCode", "Country", "Salary");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");

            foreach (DataRow row in Custmers.Rows)
            {
                Console.WriteLine("\t|{0,-4}|{1,-30}|{2,-20}|{3,-35}|{4,-21}|{5,-10}|{6,-21}|{7,-11}|",
                    row["CustomerID"], row["CustomerName"], row["ContactName"], row["Address"], row["City"],
                    row["PostalCode"], row["Country"], row["Salary"]);
                Console.WriteLine(
                    "\t+----+------------------------------+--------------------+-------------------------+---------------------+----------+---------------------+--------------------+------");
            }
            //------------------------------------------------------------------------------------------------Example 6 End :)
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = Custmers.Columns["CustomerID"];
            Custmers.PrimaryKey = PrimaryKeyColumns;    
            //---------------------------------------------------------------------------------------------------------------

            DataTable EmployeeDataTable = new DataTable();

            DataColumn dtCoulmn;
            dtCoulmn = new DataColumn();
            dtCoulmn.DataType = typeof(int);
            dtCoulmn.ColumnName = "EmployeeID";
            dtCoulmn.Caption = "Employee ID";
            dtCoulmn.AutoIncrement = true;
            dtCoulmn.AutoIncrementSeed = 1;
            dtCoulmn.AutoIncrementStep = 1;
            dtCoulmn.ReadOnly = true;
            dtCoulmn.Unique = true;
            EmployeeDataTable.Columns.Add(dtCoulmn);
            dtCoulmn = new DataColumn();
            dtCoulmn.DataType = typeof(string);
            dtCoulmn.ColumnName = "Name";
            dtCoulmn.Caption = "Employee Name";
            dtCoulmn.AutoIncrement = false;
            EmployeeDataTable.Columns.Add(dtCoulmn);
            
            
            EmployeeDataTable.Rows.Add(null,"Yazen Bilal");
            EmployeeDataTable.Rows.Add(null,"Mohammed El Khalil");
            EmployeeDataTable.Rows.Add(null,"Osman El Mahmoud");
            EmployeeDataTable.Rows.Add(null,"Ahmad El Ghazi");
            EmployeeDataTable.Rows.Add(null,"Samer El Mohamed");
            
            Console.WriteLine("\t|{0,-4}|{1,-30}|", "Employee ID","Employee Name");
            Console.WriteLine(
                "\t+----+------------------------------+--------------------+-------------------------+-");

            foreach (DataRow row in EmployeeDataTable.Rows)
            {
                Console.WriteLine("\t|{0,-4}|{1,-30}|",
                    row["EmployeeID"], row["Name"]);
                Console.WriteLine(
                    "\t+----+------------------------------+--------------------+-------------------------+-");
            }
            
            //------------------------------------------------------------------------------------------------DataTable End :)
        }
            
             
             

    }
    }
