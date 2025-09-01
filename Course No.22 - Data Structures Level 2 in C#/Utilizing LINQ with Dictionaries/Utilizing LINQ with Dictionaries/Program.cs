using System;
using System.Collections.Generic;
using System.Linq;
namespace Utilizing_LINQ_with_Dictionaries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int,string>fruits=new Dictionary<int,string>()
            {
                {1,"Apple" },
                {2,"Banana" },
                {3,"Orange" },
                {4,"Mango" },
                {5,"Grapes" },
                {6,"Pineapple" },
                {7,"Strawberry" },
                {8,"Blueberry" },
                {9,"Watermelon" },
                {10,"Peach" }
            };
            //Using LINQ to filter fruits with names longer than 5 characters
            var filteredFruits=fruits.Where(f=>f.Value.Length>5); 
            foreach(var fruit in filteredFruits)
            {
                Console.WriteLine($"Key: {fruit.Key}, Value: {fruit.Value}");
            }
            //Using LINQ to select only the fruit names
            var fruitNames=fruits.Select(f=>f.Value);
            Console.WriteLine("Fruit Names:");
            foreach(var name in fruitNames)
            {
                Console.WriteLine(name);
            }
            //Using LINQ to find the fruit with key 3
            var fruitWithKey3=fruits.FirstOrDefault(f=>f.Key==3);
            Console.WriteLine($"Fruit with Key 3: Key: {fruitWithKey3.Key}, Value: {fruitWithKey3.Value}");
            
            //Using LINQ to order fruits by name
            var orderedFruits=fruits.OrderBy(f=>f.Value);
            Console.WriteLine("Fruits ordered by name:");
            foreach (var fruit in orderedFruits)
            {
                Console.WriteLine($"Key: {fruit.Key}, Value: {fruit.Value}");
            }
            
            //Using LINQ to group fruits by the first letter of their name
            var groupedFruits = fruits.GroupBy(f => f.Value[0]);
            Console.WriteLine("Fruits grouped by the first letter:");
            foreach (var group in groupedFruits)
            {
                Console.WriteLine($"Key: {group.Key}, Value: {group.Key}");
            }
        }
            
    }
}