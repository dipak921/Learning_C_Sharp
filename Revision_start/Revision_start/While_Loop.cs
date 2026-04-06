using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- While Loop --
    - A while loop in C# is used when you want to repeat a block of code as long as a condition is true.
    while (condition)
        {
            // code to execute
        }
    - How it Works
        Condition is checked (i <= 5)
        If true, code runs
        Then i++ increases the value
        Loop repeats until condition becomes false


     
     */
    internal class While_Loop
    {
        static void Main(string[] args)
        {
            int number = 2;


            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(number + " X "+ i + " = "+ number*i);
                i++;
            }







            Console.ReadLine();
        }
    }
}
