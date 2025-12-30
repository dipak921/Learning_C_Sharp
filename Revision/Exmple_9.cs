using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Exmple_9
    {
        static void Ex2()
        {
            Console.WriteLine("Enter day of the week:");
            string day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("Office hours: 9 AM - 6 PM");
                    break;
                case "tuesday":
                    Console.WriteLine("Office hours: 9 AM - 6 PM");
                    break;
                case "wednesday":
                    Console.WriteLine("Office hours: 9 AM - 6 PM");
                    break;
                case "thursday":
                    Console.WriteLine("Office hours: 9 AM - 6 PM");
                    break;
                case "friday":
                    Console.WriteLine("Office hours: 9 AM - 6 PM");
                    break;
                case "saturday":
                    Console.WriteLine("Office hours: 9 AM - 1 PM");
                    break;
                case "sunday":
                    Console.WriteLine("Office closed");
                    break;
                default:
                    Console.WriteLine("Invalid day entered!");
                    break;
            }
        }

        static void Ex1()
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation (+, -, *, /):");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Result: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. For One Example  :");
            Console.WriteLine("2. For Second Example :");
            int ex = Convert.ToInt32(Console.ReadLine());

            if (ex == 1)
            {
                Ex1();
            }
            else if (ex == 2)
            {
                Ex2();
            }
            else { Console.WriteLine("Enter Correct Option"); }

            Console.ReadLine();
        }
    }
}
