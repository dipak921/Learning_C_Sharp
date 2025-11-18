using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    internal class create_calculator_application
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result is {0}",result);
        }
        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction Result is {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result is {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result is {0}", result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Oprator (+,-,*,/) :");
            string op = Console.ReadLine();

            if (op == "+")
            {
                create_calculator_application.Addition(num1, num2);
            }
            else if (op == "-")
            {
                create_calculator_application.Substraction(num1, num2);
            }
            else if (op == "*")
            {
                create_calculator_application.Multiplication(num1, num2);
            }
            else if (op == "/")
            {
                create_calculator_application.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Enter Properly");
            }



            Console.ReadLine();
        }
    }
}
