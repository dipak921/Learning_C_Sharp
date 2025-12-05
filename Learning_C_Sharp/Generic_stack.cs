using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
/*
 In C#, a non-generic Stack is part of the System.Collections namespace.
It is a Last-In-First-Out (LIFO) collection,
meaning the last item added is the first one to be removed.

Push(object)->Adds an object to the top of the stack
Pop()->Removes and returns the object at the top
Peek()->Returns the object at the top without removing it
Contains(obj)->Checks if an object exists
Clear()->Removes all objects
Count (property)->Gets the number of elements
 */
namespace Learning_C_Sharp
{
    internal class Generic_stack
    {

        static void displayNumber<T>(Stack<T> stack)
        {
            foreach(var item in stack)
            {
                Console.WriteLine("Print number :"+item);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> number = new Stack<int>();
            number.Push(123);
            number.Push(456);
            number.Push(789);
            number.Push(987);
            displayNumber(number);
            Console.WriteLine("-------------------------------");
            //            Count 
            //- Peek 
            //-Pop
            //- Push 
            //-Clear 

            Console.WriteLine("===Count");
            Console.WriteLine("Number of cout is :"+ number.Count);
            Console.ReadLine();
        }
    }
}
