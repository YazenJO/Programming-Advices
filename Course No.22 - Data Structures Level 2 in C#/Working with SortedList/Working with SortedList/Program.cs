using System;
using System.Collections.Generic;

namespace Working_with_SortedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            SortedList<string,string> sortedList = new SortedList<string, string>();
            sortedList.Add("a","Three");
            sortedList.Add("b", "One");
            sortedList.Add("c", "Two");

            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            // Accessing value by key
            Console.WriteLine($"Value for key 2: {sortedList["a"]}");

            // Removing an item
            sortedList.Remove("a");
            Console.WriteLine("After removing key 1:");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}