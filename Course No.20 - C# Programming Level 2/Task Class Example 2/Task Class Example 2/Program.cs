using System;
using System.Threading.Tasks;

namespace Task_Class_Example_2
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Action< string> DownloadComplete = PrintMessage;
            Task task1 = DonwloadPageAsync("https://example.com", DownloadComplete);
            Console.WriteLine(" Task 1 started, waiting for completion...");
            Task task2 = DonwloadPageAsync("https://example.org", DownloadComplete);
            Console.WriteLine(" Task 2 started, waiting for completion...");
            Task task3 = DonwloadPageAsync("https://example.net", DownloadComplete);
            Console.WriteLine(" Task 3 started, waiting for completion...");
            
            await Task.WhenAll(task1, task2, task3);
            Console.WriteLine("All tasks completed.");
            Console.ReadLine();
        }
        public static async Task DonwloadPageAsync(string url, Action<string> callback)
        {
            
            await Task.Delay(2000); 
            await Task.Delay(2000); 
            callback($"Downloaded page from {url}");
        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}