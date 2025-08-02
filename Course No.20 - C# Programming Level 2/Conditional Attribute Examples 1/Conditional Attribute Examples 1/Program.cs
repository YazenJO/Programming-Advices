#define koko
using System;
using System.Diagnostics;

namespace Conditional_Attribute_Examples_1
{
    internal class Program
    {
        [Obsolete ("This method is obsolete. Use LogTrace2 instead.")]
        public static void LogTrace(string message)
        {
           Console.WriteLine(message);
        }
        
        [Conditional("koko")]
        public static void LogTrace2(string message)
        {
            Console.WriteLine(message);
        }
        
        public static void Main(string[] args)
        {
           
            LogTrace("This is a debug message.");
            LogTrace2("This is a release message.");

            // The following line will not compile if the Conditional attribute is not met
            // LogTrace2("This will not be logged in Debug mode, but will in Release mode.");
            
            // To see the effect, you can change the build configuration to Release
            // and run the program again.
            System.Console.WriteLine("Press any key to exit...");
            System.Console.ReadKey();
        }
    }
}