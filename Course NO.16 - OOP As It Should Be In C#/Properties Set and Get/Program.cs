using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Set_and_Get
{
    internal class Program
    {
        class clsEmployee
        {
            public int ID
            {

                get;
            } = 1;

            public string Name { get; set; }
            public static string TodayDate{
                get
                {
                    return DateTime.Now.ToString();

                }
}



            static void Main(string[] args)
            {

                //Create an object of Employee class.

                clsEmployee Employee1 = new clsEmployee();

                Employee1.Name = "Test";

                Console.WriteLine("ID: " + Employee1.ID);

                Console.WriteLine("Name" + Employee1.Name);
                Console.WriteLine("Today's Date: " + clsEmployee.TodayDate);

            }
        }
    }
}

        
    
