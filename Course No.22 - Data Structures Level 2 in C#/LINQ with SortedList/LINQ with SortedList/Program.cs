using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_with_SortedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(3, "Three");
            sortedList.Add(4, "Four");
            sortedList.Add(5, "Five");

            // Using LINQ to filter and select elements from the SortedList
            var query = from item in sortedList
                where item.Key > 2
                select item.Value;
            
            Console.WriteLine("Values with keys greater than 2:");
            foreach (var value in query)
            {
                Console.WriteLine(value);
            }
            
            // Using LINQ method syntax
            var methodQuery = sortedList.Where(item => item.Key % 2 == 0).Select(item => item.Value);
            Console.WriteLine("Values with even keys:");
            foreach (var value in methodQuery)
            {
                Console.WriteLine(value);
            }
           
        }
    }
}