using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Star_Printing
    {
        static void Main()
        {
            Console.WriteLine("Enter How many Star Print in Row (Dimand Shap) ");
            int n = Convert.ToInt32(Console.ReadLine()); // height of half diamond

            // Upper part
            for (int i = 1; i <= n; i++)
            {
                // Spaces
                for (int j = i; j < n; j++)
                    Console.Write(" ");

                // Stars
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // Lower part
            for (int i = n - 1; i >= 1; i--)
            {
                // Spaces
                for (int j = n; j > i; j--)
                    Console.Write(" ");

                // Stars
                for (int k = 1; k <= (2 * i - 1); k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

    }
}