using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_7
    {
        static void Ex1()
        {
            // Declare and initialize an integer array
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("Numbers in the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void Ex2()
        {
            string[] fruits = new string[6] { "Apple", "Banana", "Cherry", "Mango", "Pineapple","Watermelon" };

            Console.WriteLine("Fruits in the array:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
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
