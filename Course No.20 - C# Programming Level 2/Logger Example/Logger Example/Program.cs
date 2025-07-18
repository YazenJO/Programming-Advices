using System;

namespace Logger_Example
{
    
    public class Logger
    {
        //In this case, LogAction can reference any method that takes a string parameter and returns void.
        public delegate void LogAction();
       // This field will store a reference to a method that matches the LogAction delegate signature
        private LogAction _logAction;
        //The constructor assigns the passed action to the _logAction field, effectively storing the method reference for later use.
        public Logger(LogAction action)
        {
            _logAction = action;
        }
        //When the Log method is called, it invokes the method referenced by the _logAction delegate. This delegate is assigned in the constructor when the Logger object is created.
        public void Log()
        {
            _logAction();
        }
    }

    public class Calculater
    {
        public delegate void LogAction(int a,int b);
        private LogAction _logAction;

        public Calculater(LogAction logAction)
        {
            _logAction = logAction;
        }

        public void Calac(int a,int b)
        {
            _logAction(a,b);
        }
    }
    
    internal class Program
    {
        //the Logger class does not create an instance of the Program class to access the method. Declaring the method as static allows it to be accessed directly via the class name
        public   static void LogToFile()
        {
            Console.WriteLine("Data hase Logged to File Suuccesfully");
        }

        public static void LogtoDataBase()
        {
            Console.WriteLine("Data hase Logged to Data Base Suuccesfully");
        }
        
        //-------------------------------------------------------
        public static void Sum(int a, int b)
        {
            Console.WriteLine("Sum is: " + (a + b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Sub is: " + (a - b));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Mul is: " + (a * b));
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine("Div is: " + (a / b));
        }
        public static void Main(string[] args)
        {
           /* Logger filelogger = new Logger(LogToFile); 
            Logger DBLogger= new Logger(LogtoDataBase);
            filelogger.Log();
            DBLogger.Log();*/
            //-------------------------------------------------
            Calculater cal = new Calculater(Sum);
            cal.Calac(10, 20);
            cal = new Calculater(Sub);
            cal.Calac(20, 10);
            cal = new Calculater(Mul);
            cal.Calac(10, 20);
            cal = new Calculater(Div);
            cal.Calac(20, 10);
            
        }
    }
}