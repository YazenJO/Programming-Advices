using System;
using System.Linq;
namespace Advanced_LINQ_Operations_on_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Array of people with Name and Age
            var people = new[]
            {
                new { Name = "Alice", Age = 30 },
                new { Name = "Bob", Age = 25 },
                new { Name = "Charlie", Age = 35 },
                new { Name = "Diana", Age = 30 },
                new { Name = "Ethan", Age = 25 }
            };


            // Grouping people by Age, then ordering within each group
            var groupedByAge = people.GroupBy(p => p.Age)
                .Select(group => new
                {
                    Age = group.Key,
                    People = group.OrderBy(p => p.Name)
                });


            // Displaying the results
            foreach (var group in groupedByAge)
            {
                Console.WriteLine($"Age Group: {group.Age}");
                foreach (var person in group.People)
                {
                    Console.WriteLine($" - {person.Name}");
                }
            }

            Console.ReadKey();
        }
            }
        }
    }
}