using System;
using System.Collections.Generic;
using System.Linq;

namespace Union_Operation_with_HashSet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>{1,2,3,4};
            HashSet<int> set2 = new HashSet<int>{2,5,6,7};
            
            set.UnionWith(set2);
            //order the set
            var orderedSet = set.OrderBy(x => x);
            foreach (var item in orderedSet)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}