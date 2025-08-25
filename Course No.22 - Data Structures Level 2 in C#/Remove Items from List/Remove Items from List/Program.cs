using System;
using System.Collections.Generic;
namespace Remove_Items_from_List
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a list with numbers from 1 to 10
                        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        
                        Console.WriteLine("Original list:");
                        Console.WriteLine(string.Join(", ", numbers));
                        
                        // Remove by value (remove the number 5)
                        numbers.Remove(5);
                        Console.WriteLine("\nAfter removing value 5:");
                        Console.WriteLine(string.Join(", ", numbers));
                        
                        // Remove by index (remove item at index 2)
                        numbers.RemoveAt(2);
                        Console.WriteLine("\nAfter removing item at index 2:");
                        Console.WriteLine(string.Join(", ", numbers));
                        
                        // Remove multiple items (remove items from index 1 to 3)
                        numbers.RemoveAll(n => n % 2 == 0);
                        Console.WriteLine("\nAfter removing range (index 1-3):");
                        Console.WriteLine(string.Join(", ", numbers));
                        
                        // Clear the list
                        numbers.Clear();
                        Console.WriteLine("\nAfter clearing the list:");
                        Console.WriteLine($"List count: {numbers.Count}");
            
        }
    }
}