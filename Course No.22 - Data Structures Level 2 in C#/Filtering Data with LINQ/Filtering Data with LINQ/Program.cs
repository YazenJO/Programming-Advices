using System;
using System.Linq;
using System.Collections.Generic;
namespace Filtering_Data_with_LINQ
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10, 11, 12, 13, 14 };
      List <int> evennumbers = numbers.Where(n => n % 2 == 0).ToList();
      List<int> oddnumbers = numbers.Where(n => n % 2 != 0).ToList();
      
      List <int> CusttomList = numbers.Where(n => n > 5).ToList();
      
      Console.WriteLine("Print All Numbers List : " + string.Join(", ",numbers));
      Console.WriteLine("Print Even Numbers List : " + string.Join(", ", evennumbers));
      Console.WriteLine("Print Odd Numbers List : " + string.Join(", ", oddnumbers));
      Console.WriteLine("Print Custom List (Numbers Greater than 5) : " + string.Join(", ", CusttomList));
      
      
    }
  }
}