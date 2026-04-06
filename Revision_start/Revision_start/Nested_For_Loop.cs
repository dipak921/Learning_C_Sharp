using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- Nested For Loop --
    A nested for loop in C# means a loop inside another loop.

👉 It is mainly used when you need to repeat a task within another repeating
    task (like rows & columns, patterns, tables, etc.)

     syntax:
                for (initialization; condition; increment/decrement)
            {
                // Outer loop code
                for (initialization; condition; increment/decrement)
                {
                    // Inner loop code
                }
            }
    **********************************************************
    *How It Works (Important Concept)
            Outer loop runs 1 time
            Inner loop runs completely
            Then outer loop runs again → inner loop runs again

            👉 So:

            Outer loop × Inner loop = Total executions


     */
    internal class Nested_For_Loop
    {
        static void Main(string[] args)
        {
           for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Outer Loop: " + i);
                for(int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("   Inner Loop: " + j);
                }
            }


            Console.ReadLine();
        }
    }
}
