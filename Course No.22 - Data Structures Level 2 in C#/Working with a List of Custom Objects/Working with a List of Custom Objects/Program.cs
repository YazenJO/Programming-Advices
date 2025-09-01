using System;
using System.Collections.Generic;
using System.Linq;
namespace Working_with_a_List_of_Custom_Objects
{
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
      return $"Name: {Name}, Age: {Age}";
    }
    
    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }
  }
  internal class Program
  {
    public static void Main(string[] args)
    {
      List<Person> people = new List<Person>();
      people.Add(new Person("Alice", 30));
      people.Add(new Person("Bob", 25));
      people.Add(new Person("Charlie", 35));
      foreach (var person in people)
      {
        Console.WriteLine(person);
      }
      var adults = people.Where(p => p.Age >= 30).ToList();
      Console.WriteLine("\nAdults (Age >= 30):");
      foreach (var adult in adults)
      {
        Console.WriteLine("Adult Na,e : " + adult.Name);
      }
      var bob = people.FirstOrDefault(p => p.Name == "Bob");
      if (bob != null)
      {
        Console.WriteLine("\nFound Bob: " + bob);
      }

      if (people.Exists(p => p.Name == "Charlie"))
      {
        Console.WriteLine("\nCharlie exists in the list.");
      }
      people.RemoveAll(p => p.Age < 30);
      Console.WriteLine("\nPeople after removing those younger than 30:");
      foreach (var person in people)
      {
        Console.WriteLine(person);
        
      }
    }
  }
}