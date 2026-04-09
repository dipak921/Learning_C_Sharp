using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class Constructor_Overloading
    {
        public Constructor_Overloading() 
        {
            Console.WriteLine("This is a default constructor.");
        }

        public Constructor_Overloading(string message)
        {
            Console.WriteLine("This is a parameterized constructor. Message: " + message);
        }

        public Constructor_Overloading(int number)
        {
            Console.WriteLine("This is a parameterized constructor. Number: " + number);
        }


        static void Main(string[] args)
        {
            // Compile time check
            Constructor_Overloading obj1 = new Constructor_Overloading();
            Constructor_Overloading obj2 = new Constructor_Overloading("Hello, World!");
            Constructor_Overloading obj3 = new Constructor_Overloading(44);




            Console.ReadLine();
        }
    }
}
