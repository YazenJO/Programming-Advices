using System;
using System.Threading.Tasks;
namespace Task_Class_With_Call_back_Event_Example
{
    public class CustemEvent : EventArgs
    {
        public int number {get; set; }
        public string s1 { get; set; }
        
        public CustemEvent(int number, string s)
        {
            this.number = number;
            this.s1 = s;
        }
    }
    internal class Program
    {
        public delegate void CustomEventHandler(object sender, CustemEvent e);
        public static event CustomEventHandler CallBackEvent;
        
        public static async Task Main(string[] args)
        {
            CallBackEvent += OnCallBackEvent;
           

            Task performeTask = PerformTask(CallBackEvent);
            Console.WriteLine("Task started, waiting for completion...");
            await performeTask;
            Console.WriteLine("Task completed.");
        }

        public async static Task PerformTask(CustomEventHandler callback)
        {
           await Task.Delay(2000); // Simulate some work
           callback?.Invoke(null, new CustemEvent(42, "Hello from Task!"));
           
        }

        static void OnCallBackEvent(object sender, CustemEvent e)
        {
            Console.WriteLine($"Event triggered with number: {e.number} and string: {e.s1}");
        }   
       
    }
      
}