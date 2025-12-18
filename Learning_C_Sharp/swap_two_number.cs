using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class swap_two_number
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before: a={a}, b={b}");

            a = a + b;  // a = 30
            b = a - b;  // b = 10
            a = a - b;  // a = 20

            Console.WriteLine($"After: a={a}, b={b}");  // a=20, b=10 [web:1]



            Console.ReadKey();
        }
    }
}
