using System;
using System.Threading;
using System.Threading.Tasks;
namespace Introduction_to_Task_Factory_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationTokenSource task2Cts = new CancellationTokenSource();
            
            CancellationToken token = cts.Token;
            CancellationToken token2 = task2Cts.Token;
            
            
            TaskFactory taskFactory = new TaskFactory(token,TaskCreationOptions.AttachedToParent,
                                                        TaskContinuationOptions.ExecuteSynchronously,TaskScheduler.Default);
            Task task1 = taskFactory.StartNew(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        // Handle cancellation request
                        Console.WriteLine("Task was cancelled.");
                        return;
                    }
                    Console.WriteLine($"Task is running: {i}");
                    Thread.Sleep(1000); // Simulate work
                }
            });
            cts.CancelAfter(10);
            Task task2 = taskFactory.StartNew(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    if (token2.IsCancellationRequested)
                    {
                        // Handle cancellation request
                        Console.WriteLine("Task2 was cancelled.");
                        return;
                    }
                    Console.WriteLine($"Task2 is running: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });
            
            try
            {
                
                Task.WaitAll(task1, task2);
                Console.WriteLine("All tasks completed.");
            }
            catch (AggregateException ae)
            {
             
                foreach (var e in ae.InnerExceptions)
                    Console.WriteLine($"Exception: {e.Message}");
            }


            
            cts.Dispose();
        }
    }
}