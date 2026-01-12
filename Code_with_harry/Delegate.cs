using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    /*
     Delegate ->  A delegate is a type-safe reference to a method that allows methods to be passed as parameters and called dynamically at runtime.
     
     */
    public delegate void Calculation(int a, int b);
    internal class Delegate
    {
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addtion is :{result}");
        }
        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtraction is :{result}");
        }
        public static void Multi(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplacation is :{result}");
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Division is :{result}");
        }

        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Delegate.Add);
            obj.Invoke(10, 20); //30

            // Second Mehtod to call another method
            obj = Sub;
            obj(20, 5); //15

            obj = Multi;
            obj(20, 5); //100

            obj = Division;
            obj(20, 5); //4




            Console.ReadLine();
        }
    }
}
