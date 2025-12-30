using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_4
    {
        static void Ex1()
        {
            /*Write a C# program that keeps asking the user to enter numbers. 
             * The program should add all positive numbers entered. 
             * If the user enters a negative number, stop the loop and display the total sum. Use a do-while loop.*/

            int number;
            int sum = 0;

            do
            {
                Console.Write("Enter a number (negative to stop): ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number >= 0)
                {
                    sum += number;
                }

            } while (number >= 0);

            Console.WriteLine("Total sum of positive numbers: " + sum);
        }

        static void Ex2() 
        {
            /*Write a C# program that asks the user to enter a number. The program should print the multiplication table of that number up to 10. After printing, ask the user if they want to generate another table. If the user enters "y", repeat; otherwise stop. Use a do-while 
*/
            int number;
            string choice;

            do
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Multiplication Table of " + number);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " x " + i + " = " + (number * i));
                }

                Console.Write("Do you want to generate another table? (yes/no): ");
                choice = Console.ReadLine();

            } while (choice.ToLower() == "yes");

            Console.WriteLine("Program ended.");
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
