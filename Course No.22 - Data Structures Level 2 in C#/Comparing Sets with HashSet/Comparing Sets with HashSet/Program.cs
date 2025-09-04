using System;
using System.Collections.Generic;

namespace Comparing_Sets_with_HashSet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int>() { 1,2};

            // set Equals
            Console.WriteLine("Set A equals Set B: " + setA.SetEquals(setB));
            // is subset
            Console.WriteLine("Set A is subset of Set B: " + setB.IsSubsetOf(setA));
            // is superset
            Console.WriteLine("Set A is superset of Set B: " + setA.IsSupersetOf(setB));
            // Overlaps
            Console.WriteLine("Set A overlaps Set B: " + setA.Overlaps(setB));
        }
    }
}