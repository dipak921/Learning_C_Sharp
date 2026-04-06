using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- The Switch Case Statement
    - A program is difficult to comprehend when there are too many if statements representing multiple selection constructs.
    - To avoid using multiple if statements, in certain cases, the switch.. case approach can be used as an alternative
    - The switch..case statement is used when a variable needs to be compared against different values.
    - In C#, the flow of execution from one  case statement is not allowed to continue to the next case statement and is referred to as the no-fall-through rule of C#.
     */
    internal class Switch_Case
    {
        static void Main(string[] args)
        {
            int week_number = 9;

            switch(week_number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Week Number");
                    break;
            }




            Console.ReadLine();
        }
    }
}
