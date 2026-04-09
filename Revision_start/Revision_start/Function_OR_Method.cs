using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     --    Functions and Methods in C#
    - A method is a group of statements that together perform a task.      
    - Methods are fucntions declared in a class and may be used to perform operations, return a value, or modify the state of an object.

     
     */
    internal class Function_OR_Method
    {
        // Non- parameterized method
        public void MyMethod()
        {
            Console.WriteLine("This is a method.");
        }

        public static void MyMethod2()
        {
            Console.WriteLine("This is a static method.");
        }


        // parameterized method
        public static void MyMethod3(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }




        static void Main(string[] args)
        {
            Function_OR_Method obj = new Function_OR_Method();
            obj.MyMethod(); // Calling the method to execute its code

            Function_OR_Method.MyMethod2(); // Calling the static method to execute its code

            // Parameterized method call
            Function_OR_Method.MyMethod3("Dipak"); // Calling the parameterized method with an argument


            Console.ReadLine();
        }
    }
}
