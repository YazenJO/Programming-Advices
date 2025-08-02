using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
namespace Task_Class
{
    internal class Program
    {
        public static async Task  Main(string[] args)
        {
            Task <int> resultAsync = PerformAsync();
            
            Console.WriteLine(" Waiting for the result... ");
            // Await the result of the asynchronous operation
            int result = await resultAsync;
            
            Console.WriteLine($"Result: {result}");
        }
        public static async Task<int> PerformAsync()
        {
            await Task.Delay(5000);
            return 42;
        }
    }
}