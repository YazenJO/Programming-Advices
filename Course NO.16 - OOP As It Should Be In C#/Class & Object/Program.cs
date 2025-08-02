using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___Object
{
    public class clsPerson
    {
        public string FirsName;
        public string LastName;//Every Object has it's own space in memory that holds only Data Members.

        public string FullName()  //Function Members are shared to all objects in memory and has one memory space for them.
        {
            return FirsName + " " + LastName;
        }





    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson person = new clsPerson(); 
            person.FirsName = "John";
            person.LastName = "Doe";    
            person.FullName();
            Console.WriteLine(person.FullName());

            clsPerson person2 = new clsPerson();
            person2.FirsName = "Ahmed";
            person2.LastName = "Smith";
            person2.FullName();
            Console.WriteLine(person2.FullName());
        }
    }
}
