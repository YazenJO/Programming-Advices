using System;
using System.Collections;
namespace Working_with_Hashtable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 1);
            ht.Add(2, "Yazen");
            ht.Add(3, 3.5);
            ht.Add(4, true);
            ht.Add(5, 'A');
            
            Console.WriteLine("Index 1 : " + ht[(1)]);
            Console.WriteLine("Index 2 : " + ht[2]);
            
            //modify
            ht[2] = "Modified Yazen";
            ht[2] = "Modified Yazen";
            //remove elemnt
            ht.Remove(3);
            //itirate
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}