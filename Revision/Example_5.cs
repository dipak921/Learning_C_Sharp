using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_5
    {
        static void Ex1()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Numbers in the array:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        static void Ex2()
        {
            List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry", "Mango" };

            Console.WriteLine("Fruits in the list:");
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
