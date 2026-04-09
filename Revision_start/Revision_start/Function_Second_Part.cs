using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    class Function_Second_Part
    {

        // Method without return type
        public static void Show_Name_Age(string name, int age)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }


        // Method with return type
        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            // Calling method with normal arguments
            Function_Second_Part.Show_Name_Age("Dipak", 25);

            // Calling method with named arguments
            Function_Second_Part.Show_Name_Age(age: 25, name: "Dipak");

            // Calling method with return type
            Console.WriteLine(Function_Second_Part.Add(10, 20));
        }
    }
}