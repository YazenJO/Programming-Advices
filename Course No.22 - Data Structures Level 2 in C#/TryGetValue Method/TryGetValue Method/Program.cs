using System;
using System.Collections.Generic;
namespace TryGetValue_Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            if (dictionary.TryGetValue(2, out string value))
            {
                Console.WriteLine($"Key found: {value}");
            }
            else
            {
                Console.WriteLine("Key not found.");
            }

            if (dictionary.TryGetValue(4, out value))
            {
                Console.WriteLine($"Key found: {value}");
            }
            else
            {
                Console.WriteLine("Key not found.");
            }
            
        }
    }
}