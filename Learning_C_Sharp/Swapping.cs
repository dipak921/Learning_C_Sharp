using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Swapping
    {
        static void Main(string[] args)
        {
            int a = 20; 
            int b = 30;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            a = a + b; // a = 20 + 30, a = 50
            b = a - b; // b = 50 - 30, b = 20
            a = a - b; // a = 50 - 20, a = 30

            Console.WriteLine("-------------- Swap Result ------------");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);



            Console.ReadLine();
        }
    }

}
