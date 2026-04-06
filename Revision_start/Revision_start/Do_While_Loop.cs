using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- Do While Loop --
    - A do-while loop in C# is similar to a while loop, but with one important difference:
    -  It always executes at least once, even if the condition is false.
    - Syntax:
                do
            {
                // code to execute
            } 
            while (condition);

    When to Use do-while

            Use it when:
            You must run code at least once
            You are taking user input
            You are building menus or validation systems



    */
    internal class Do_While_Loop
    {
        static void Main(string[] args)
        {
            int i = 6;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);





            Console.ReadLine();
        }
    }
}
