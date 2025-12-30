using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_6
    {
        static void Ex1()
        {
            int sum = 0;
            int number = 1;

            while (sum <= 100)
            {
                sum += number;
                number++;
            }

            Console.WriteLine("Final sum: " + sum);
            Console.WriteLine("Numbers added: " + (number - 1));
        }
        static void Ex2()
        {
            string input = "";

            Console.WriteLine("Type something (type 'exit' to stop):");
            while (input != "exit")
            {
                input = Console.ReadLine();
                Console.WriteLine("You typed: " + input);
            }
        }

        static void Main() 
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
