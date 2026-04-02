using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /* 
     * --- Variable ---
    Variable is a container that holds the value of a data type.
     It is used to store data in memory. 
    variable is used to contain the data that can be changed dynamically during the execution of the program.
    - varabale represented by data type and indetifier.
    - syntax: data_type variable_name = value;

    1. Global variable : 
       This type of variable is declared udner class and in case of static it will be called by 
       class name and in case of instance it will be called by object name.
     class A
     {
         int a; // instance variable
         static int b; // static variable
     }
        2. Local variable:
            This type of variable declared under function and it will be called by function name and it will be destroyed after the execution of the function.
        Class A
        {
            static void Function1()
            {
                int a; // local variable
            }
            void Function2()
            {
                int b; // Instance variable
            }
        }
    
     
     */
    internal class Variable
    {
        static int y = 100;
        int a = 10;

        static void Main(string[] args)
        {
            Variable obj = new Variable();
            Console.WriteLine("The value of a is: " + obj.a);
            Console.WriteLine("The value of y is: " + y);

            Console.ReadLine();
        }
    }
}
