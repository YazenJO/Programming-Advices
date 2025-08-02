using System;
using System.Data;

namespace Dataview
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataTable EmployeeDataTabale = new DataTable();


            EmployeeDataTabale.Columns.Add("ID", typeof(int));
            EmployeeDataTabale.Columns.Add("Name", typeof(string));
            EmployeeDataTabale.Columns.Add("Country", typeof(string));
            EmployeeDataTabale.Columns.Add("Salary", typeof(double));
            EmployeeDataTabale.Columns.Add("Time", typeof(DateTime));

            // Primary Key = ID
            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = EmployeeDataTabale.Columns["ID"];
            EmployeeDataTabale.PrimaryKey = PrimaryKey;


            EmployeeDataTabale.Rows.Add(1, "Sayed Ahmad", "EGY", 10000, DateTime.Now);
            EmployeeDataTabale.Rows.Add(2, "Mohamed Ahmad", "EGY", 15000, DateTime.Now);
            EmployeeDataTabale.Rows.Add(3, "Maher Ali", "USA", 1000, DateTime.Now);
            EmployeeDataTabale.Rows.Add(4, "Ali samh", "EGY", 10000, DateTime.Now);
            EmployeeDataTabale.Rows.Add(5, "Sror refat", "KSA", 1500, DateTime.Now);
            EmployeeDataTabale.Rows.Add(6, "Habiba Ahmad", "JRD", 1300, DateTime.Now);

            foreach (DataRow dataRow in EmployeeDataTabale.Rows)
            {
                Console.WriteLine($"ID : {dataRow["ID"]} \t Name : {dataRow["Name"]} \t " +
                                  $"Country : {dataRow["Country"]} \t" +
                                  $"Salary : {dataRow["Salary"]} \t Time : {dataRow["Time"]} ");
            }


            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Data View :\n");

            DataView dataView = EmployeeDataTabale.DefaultView;
            foreach (DataRowView dataRowView in dataView)
            {
                Console.WriteLine($"ID : {dataRowView["ID"]} \t Name : {dataRowView["Name"]} \t " +
                                  $"Country : {dataRowView["Country"]} \t" +
                                  $"Salary : {dataRowView["Salary"]} \t Time : {dataRowView["Time"]} ");
            }

            //----------------------------------------------------------------
            //Dataview Filter
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Filter DataView by Country = EGY:\n");
            dataView.RowFilter = "Country=''";
            dataView.RowFilter = "Country = 'EGY'";
            foreach (DataRowView dataRowView in dataView)
            {
                Console.WriteLine($"ID : {dataRowView["ID"]} \t Name : {dataRowView["Name"]} \t " +
                                  $"Country : {dataRowView["Country"]} \t" +
                                  $"Salary : {dataRowView["Salary"]} \t Time : {dataRowView["Time"]} ");
            }

         
            dataView.Sort = "Name ASC";
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Sorted DataView by Name (Ascending):\n");
            foreach (DataRowView dataRowView in dataView)
            {
                Console.WriteLine($"ID : {dataRowView["ID"]} \t Name : {dataRowView["Name"]} \t " +
                                  $"Country : {dataRowView["Country"]} \t" +
                                  $"Salary : {dataRowView["Salary"]} \t Time : {dataRowView["Time"]} ");

            }
        }
    }
}