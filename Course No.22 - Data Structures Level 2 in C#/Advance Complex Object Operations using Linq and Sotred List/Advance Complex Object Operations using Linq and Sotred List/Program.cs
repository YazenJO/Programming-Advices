using System.Collections.Generic;
using System.Linq;

namespace Advance_Complex_Object_Operations_using_Linq_and_Sotred_List
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SortedList<int, Employee> employees = new SortedList<int, Employee>()
            {
                { 1, new Employee() { Id = 1, Name = "John", Age = 30, Salary = 50000 } },
                { 2, new Employee() { Id = 2, Name = "Jane", Age = 25, Salary = 60000 } },
                { 3, new Employee() { Id = 3, Name = "Jake", Age = 35, Salary = 70000 } },
                { 4, new Employee() { Id = 4, Name = "Jill", Age = 28, Salary = 80000 } },
                {
                    5, new Employee() { Id = 5, Name = "James", Age = 32, Salary = 90000 }
                }
            };

            // Get all employees with salary greater than 60000
            var highSalaryEmployees = employees.Values
                .Where(e => e.Salary > 60000)
                .ToList();
            
                
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
        }
    }
}