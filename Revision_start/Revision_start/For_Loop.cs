using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- For Loop --
    - Loops allow you to repeat a block of code multiple times.
    - A for loop is a control flow statement that allows you to execute a block of code a specific number of times.
    - The syntax of a for loop is as follows:
    for (initialization; condition; increment/decrement)
    {
        // Code to be executed
    }
     
     */
    internal class For_Loop
    {
        static void Main(string[] args)
        {

            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Hello World! " + i);
            }

            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number +" X " +  i + " = " + number * i);
            }


            Console.ReadLine();
        }
    }
}
