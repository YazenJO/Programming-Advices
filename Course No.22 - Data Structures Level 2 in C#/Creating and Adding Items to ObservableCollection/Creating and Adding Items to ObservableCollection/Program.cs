
using System;
using System.Collections.ObjectModel;

namespace Creating_and_Adding_Items_to_ObservableCollection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ObservableCollection<string> names = new ObservableCollection<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Doe");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}