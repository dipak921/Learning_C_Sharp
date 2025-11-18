using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Constructor_overloading
    {
        public Constructor_overloading()
        {
            Console.WriteLine("First Defualt Constructor");
        }

        public Constructor_overloading(int a, int b)
        {
            Console.WriteLine($"2 Parameter Counstructor sum : {a + b}");
        }
        public Constructor_overloading(int a, int b, int c)
        {
            Console.WriteLine($"2 Parameter Counstructor sum : {a + b + c}");
        }
        public Constructor_overloading(int a, int b, string c)
        {
            Console.WriteLine($"2 Parameter Counstructor sum : {a + b } {c}");
        }

        public Constructor_overloading(string a, string b, string c)
        {
            Console.WriteLine($"2 Parameter Counstructor sum : {a} {b} {c}");
        }
        static void Main(string[] args)
        {
            Constructor_overloading c = new Constructor_overloading();
            Constructor_overloading c1 = new Constructor_overloading(20,3);
            Constructor_overloading c2 = new Constructor_overloading(20,30,5); //
            Constructor_overloading c3 = new Constructor_overloading(20,30,"Ram"); //
            Constructor_overloading c4 = new Constructor_overloading("Sagar","Mheveen","Pandu");

            Console.WriteLine($"------------------Copy Constructor-----------------");




            Console.ReadLine();
        }
    }
}
