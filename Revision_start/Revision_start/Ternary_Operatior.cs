using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- * Ternary Operator
    C# includes a special type of decision-making operator? : called the ternary operator. 

    Syntax: Boolean_Expression ? Expression1 : Expression2
     */
    internal class Ternary_Operatior
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age : ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = (a >= 18) ? "You are Eligiable to Vote" : "Your not Eligiable to Vote";

            Console.WriteLine(b);


            Console.ReadLine();
        }
    }
}
