using System;
using System.Collections.Generic;

namespace Looping_Through_a_List
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a sample list
                        List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Grape", "Mango" };
                        
                        // Example 1: Using for loop
                        Console.WriteLine("Example 1: Using for loop");
                        for (int i = 0; i < fruits.Count; i++)
                        {
                            Console.WriteLine($"Index {i}: {fruits[i]}");
                        }
                        
                        Console.WriteLine();
                        
                        // Example 2: Using foreach loop
                        Console.WriteLine("Example 2: Using foreach loop");
                        foreach (string fruit in fruits)
                        {
                            Console.WriteLine($"Fruit: {fruit}");
                        }
            
                        Console.WriteLine();
                        
                        // Example 3: Using List.ForEach method
                        Console.WriteLine("Example 3: Using List.ForEach method");
                        fruits.ForEach(b => Console.WriteLine($"Fruit: {b}"));
        }
    }
}