using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class Operation
    {
        int a, b;
        void Accept()
        {
            Console.WriteLine("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        void Add()
        {
            int c = a + b;
            Console.WriteLine("The sum of a and b is: " + c);
        }

        void Subtract()
        {

            int c = a - b;
            Console.WriteLine("The difference of a and b is: " + c);
        }

        void Multiply()
        {
            int c = a * b;
            Console.WriteLine("The product of a and b is: " + c);
        }

        void Divide()
        {
            int c = a / b;
            Console.WriteLine("The quotient of a and b is: " + c);
        }
        static void Main(string[] args)
        {
            Operation p = new Operation();
            p.Accept();
            p.Add();
            p.Subtract();
            p.Multiply();
            p.Divide();

            Console.ReadLine();
        }
    }
}
