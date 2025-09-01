
using System.Collections.Generic;

namespace Working_with_Dictionary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();
            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Orange", 3);
            fruitBasket.Add("Pear", 2);
            fruitBasket.Add("Banana", 1);
            fruitBasket.Remove("Apple");
            
            fruitBasket["Apple"] = 10;
            fruitBasket.Remove("Orange");

            foreach (KeyValuePair<string, int> kvp in fruitBasket)
            {
                System.Console.WriteLine($"Fruit: {kvp.Key}, Quantity: {kvp.Value}");
            }
            //nested dictionary
            Dictionary<string, Dictionary<string, int>> nestedFruitBasket = new Dictionary<string, Dictionary<string, int>>();
            nestedFruitBasket.Add("Citrus", new Dictionary<string, int>());
            nestedFruitBasket["Citrus"].Add("Orange", 3);
            nestedFruitBasket["Citrus"].Add("Lemon", 5);
            nestedFruitBasket.Add("Berries", new Dictionary<string, int>());
            nestedFruitBasket["Berries"].Add("Strawberry", 10);
            nestedFruitBasket["Berries"].Add("Blueberry", 20);
            foreach (KeyValuePair<string, Dictionary<string, int>> category in nestedFruitBasket)
            {
                System.Console.WriteLine($"Category: {category.Key}");
                foreach (KeyValuePair<string, int> fruit in category.Value)
                {
                    System.Console.WriteLine($"\tFruit: {fruit.Key}, Quantity: {fruit.Value}");
                }
            }
        }
    }
}