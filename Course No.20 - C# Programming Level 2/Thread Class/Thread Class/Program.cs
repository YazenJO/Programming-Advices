using System;
using System.Threading;
namespace Thread_Class
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create two threads
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);

            // Start the threads
            thread1.Start();
            thread2.Start();

            // Wait for both threads to finish
            thread1.Join();

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                //Thread.Sleep(1000); // Sleep for 1 secon
            }
            Console.WriteLine("Both methods have completed execution.");
        }

        public static void Method1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1: " + i);
               // Thread.Sleep(1000); // Sleep for 1 secon
            }
        }
        public static void Method2()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Method2: " + i);
                //Thread.Sleep(1000); // Sleep for 1 second
            }
        }
        
    }
}