using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_LINQ_Usage_with_SortedList_Grouping_Elements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SortedList <string ,string > FoodBaket = new SortedList<string, string>
            {
                {"Apple", "Fruit"},
                {"Banana", "Fruit"},
                {"Carrot", "Vegetable"},
                {"Broccoli", "Vegetable"},
                {"Chicken", "Meat"},
                {"Beef", "Meat"},
                {"Orange", "Fruit"},
                {"Spinach", "Vegetable"}
            };
            
            Console.WriteLine("Grouping by Food Category:");
            var groups = FoodBaket.GroupBy(item => item.Value);
            foreach (var group in groups)
            {
                Console.WriteLine($"\nCategory: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($" - {item.Key}");
                }
            }
        }
    }
}