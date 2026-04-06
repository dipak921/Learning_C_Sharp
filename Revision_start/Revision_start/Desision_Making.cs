using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
    -- Decision Making Statements OR Selection Statements
    - Selection Constructs is a programming construct supported by C# that controls the flow of a program.
    - Executes a particular block of statements based on a boolean condition, which is an expression returning true or false.
    - Is refred to as desision making constructs.
    - Allow you to take logical decisions about executing different blocks of a program to achieve the required logical Output.
    
    C# supports the following selection constructs:
    1. if statement
    2. if-else statement
    3. if-else-if ladder
    4. switch statement
    
     
     */
    internal class Desision_Making
    {
        static void Main(string[] args)
        {

            int x = 5;

            if(x > 10)
            {
                Console.WriteLine("X is greater..");
            }
            else
            {
                Console.WriteLine("X is smaller..");
            }

            Console.WriteLine("----------------------------");

            string name = Console.ReadLine();
            if (name == "Dipak")
            {
                Console.WriteLine("Welcome Dipak..");
            }
            else
            {
                Console.WriteLine("Welcome Guest..");
            }

            /*
             -- The IF Statement
            1. The if statement allows you to execute a block of statements after evaluating the specified logical condition.
            2. The if Statement start wiht the keyword and is followed by the condition.
            3. If the condition evaluates to true, the block of statements following the if statement is executed.

            -- The IF-ELSE Statement
            1. In some situations, it is required to define an action for a false condition by using an if....else construct.
            2. The if..else cosnstruct with the if block followed by an else block and the else block starts with the else keyword followed by a block of statements.
            3. If the condition evaluates to true, the block of statements following the if statement is executed, otherwise the block of statements following the else statement is executed.
             */




            Console.ReadLine();
        }
    }
}
