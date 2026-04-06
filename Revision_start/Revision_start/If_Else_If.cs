using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- The IF-ELSE-IF Ladder
    1. The if-else-if ladder is used to select one of the many blocks of statements to be executed.
    2. The if-else-if ladder is a nested if statement that allows you to check multiple conditions.
    3. The if-else-if ladder is a sequence of if statements, where each if statement is followed by an else statement, except the last one.

     */
    internal class If_Else_If
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Percentage : ");
            int percentage = Convert.ToInt32(Console.ReadLine());

            if(percentage >= 80 )
            {
                Console.WriteLine("Garade : A-1");
            }
            else if(percentage >= 70)
            {
                Console.WriteLine("Grade : A");
            }
            else if(percentage >= 60)
            {
                Console.WriteLine("Grade : B");
            }
            else if(percentage >= 50)
            {
                Console.WriteLine("Grade : C");
            }
            else if(percentage >= 40)
            {
                Console.WriteLine("Grade : D");
            }
            else
            {
                Console.WriteLine("Grade : F");
            }





            Console.ReadLine();
        }
    }
}
