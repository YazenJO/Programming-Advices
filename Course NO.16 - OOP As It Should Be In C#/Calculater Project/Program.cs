using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Calculater1
{
    static private double _Result=0;
    
    static public  void Add(double Number)
    {
        _Result += Number;
    }
    static public void Subtract(double Number) {
        _Result -= Number; 
    }
    static public void Multiply(double Number) {
        _Result *= Number;
    }
    static public void Clear()
    {
        _Result = 0;
    }
    static public void Divide(double Number)
    {
        if (Number == 0)
            return;
            _Result /= Number;
    }
    static public void PrintResult()
    {
        Console.WriteLine(_Result.ToString()); 
    }
}


namespace Calculater_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculater1.Clear();

            Calculater1.Add(10);
            Calculater1.PrintResult();

            Calculater1.Add(100);
            Calculater1.PrintResult();

            Calculater1.Subtract(20);
            Calculater1.PrintResult();

            Calculater1.Divide(0);
            Calculater1.PrintResult();

            Calculater1.Divide(2);
            Calculater1.PrintResult();

            Calculater1.Multiply(3);
            Calculater1.PrintResult();

            Calculater1.Clear();
            Calculater1.PrintResult();

            Console.ReadKey();



        }
    }
}
