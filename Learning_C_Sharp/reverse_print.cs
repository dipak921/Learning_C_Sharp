using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class reverse_print
    {
        static void Main(string[] args)
        {
            char letter1, letter2, letter3;

            Console.Write("Enter letter: ");
            letter1 = Convert.ToChar(Console.ReadLine().Trim());

            Console.Write("Enter letter: ");
            letter2 = Convert.ToChar(Console.ReadLine().Trim());

            Console.Write("Enter letter: ");
            letter3 = Convert.ToChar(Console.ReadLine().Trim());

            Console.WriteLine($"{letter3} {letter2} {letter1}");



            Console.ReadKey();
        }
    }
}
