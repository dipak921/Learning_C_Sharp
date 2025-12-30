using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_3
    {
        static void Ex1()
        {
            /*he following rules:
- Marks ≥ 90 → Grade A
- Marks ≥ 75 and < 90 → Grade B
- Marks ≥ 60 and < 75 → Grade C
- Marks ≥ 40 and < 60 → Grade D
- Marks < 40 → Fail
👉 You must use nested
             */
            Console.Write("Enter your marks(0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else
            {
                if (marks >= 75)
                {
                    Console.WriteLine("Grade B");
                }
                else
                {
                    if (marks >= 60)
                    {
                        Console.WriteLine("Grade C");
                    }
                    else
                    {
                        if (marks >= 40)
                        {
                            Console.WriteLine("Grade D");
                        }
                        else
                        {
                            Console.WriteLine("Fail");
                        }
                    }
                }
            }

        }
        static void Ex2()
        {
            /*Write a C# program that takes an integer input and classifies it as:
            - Positive Even
            - Positive Odd
            - Negative Even
            - Negative Odd
            - Zero
            */
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("Positive Even");
                else
                    Console.WriteLine("Positive Odd");
            }
            else
            {
                if (number < 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("Negative Even");
                    else
                        Console.WriteLine("Negative Odd");
                }
                else
                {
                    Console.WriteLine("Zero");
                }
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
