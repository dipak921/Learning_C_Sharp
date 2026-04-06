using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- * Precedence of Operators
     Operators in C# have certain associated priority Levels.
     The C# compiler executes operatrs in the sequence defined by the priority levels of 
    the operators. The precedence of operators is as follows:
    higest precedence --  (), /,  *, + -
    EX. 8/2-3+2*2


     */
    internal class Precedence_Operator
    {
        static void Main(string[] args)
        {
            int a = 8 / 2 - 3 + 2 * 2;
            // 1. 8/2 = 4
            // 2. 2*2 = 4
            // 3. 4-3 = 1
            // 4. 1+4 = 5
            Console.WriteLine(a); // 5

            int b = 8 / 2 - (3 + 2) * 2;
            // 1. 3+2 = 5
            // 2. 5*2 = 10
            // 3. 8/2 = 4
            // 4. 4-10 = -6
            Console.WriteLine(b);



            Console.ReadLine();
        }
    }
}
