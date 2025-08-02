using System;
using System.Diagnostics;

namespace Main
{
    internal class Program
    {



        static void Main(string[] args)
        {

            //you dont specify any type here , automatically will be specified
            var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };
            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Mohammed
            Console.WriteLine(student.LastName); //output: Abu-Hadhoud

            //You can print like this:
            Console.WriteLine(student);


            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot chage value
            // student.FirstName = "Ali";//Error: cannot chage value


            //An anonymous type's property can include another anonymous type.
            var YazenInfo = new {
                Id = 1,
                FirstName = "Yazen",
                LastName = "Bilal",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" }

            };

            Console.WriteLine("\nExample 2 : \n");
            Console.WriteLine(YazenInfo.Id);
            Console.WriteLine(YazenInfo.FirstName);
            Console.WriteLine(YazenInfo.LastName);
            Console.WriteLine(YazenInfo.Address);

            Console.ReadKey();

        }
    }
}