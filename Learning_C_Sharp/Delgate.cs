using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    public delegate void calculation(int a, int b);
    internal class Delgate
    {
        public static void addtion(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addtion is : " +result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is : " + result);
        }
        public static void multiplaction(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplaction is : " + result);
        }
        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("division is : " + result);
        }
        static void Main(string[] args)
        {
            calculation obj = new calculation(Delgate.addtion);
            obj.Invoke(10, 20);   
            obj(10, 8);   // second way to pass value

            obj = Subtraction;
            obj(30, 15);










            Console.ReadLine();
        }
    }
}
