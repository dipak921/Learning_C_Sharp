using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Round
{
    internal class Findfactorial03
    {
        static void Main(string[] args)
        {
            int number = 3;
            // Store the number

            long factorial = 1;
            // Initialize factorial as 1
            // We use long because factorial grows very fast

            for (int i = 1; i <= number; i++)
            // Loop from 1 to the given number
            {
                factorial *= i;
                // Multiply factorial by current value of i
                // factorial = factorial * i
            }

            Console.WriteLine("Factorial is: " + factorial);
            // Print the result




        }
    }
}
