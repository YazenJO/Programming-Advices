using System.Collections.Generic;
using System.Linq;
namespace Exploring_Linq_Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Contains, Exists, Find, FindAll, and Any with List of Strings
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
            bool containsAlice = names.Contains("Alice");
            bool existsBob = names.Exists(name => name == "Bob");
            string findCharlie = names.Find(name => name == "Charlie");
            List<string> findAllWithE = names.FindAll(name => name.Contains("e"));
            bool anyStartsWithD = names.Any(name => name.StartsWith("D"));
            //Output results
            System.Console.WriteLine($"Contains 'Alice': {containsAlice}");
            System.Console.WriteLine($"Exists 'Bob': {existsBob}");
            System.Console.WriteLine($"Find 'Charlie': {findCharlie}");
            System.Console.WriteLine($"FindAll with 'e': {string.Join(", ", findAllWithE)}");
            System.Console.WriteLine($"Any starts with 'D': {anyStartsWithD}");
            
        }
    }
}