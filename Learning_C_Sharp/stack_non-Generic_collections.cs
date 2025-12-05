using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 What is a Non-Generic Stack?
- In C#, Stack (from System.Collections) is a non-generic collection.
- It stores elements as object, so you can mix types (string, int, float, etc.).
- It follows LIFO (Last-In-First-Out) principle: the last item pushed is the first item popped.

- शेवटचा element आधी बाहेर येतो (LIFO).
- Properties:
- Count → किती elements आहेत
- Peek → वरचा element दाखवतो पण काढत नाही
- Pop → वरचा element काढतो
- Push → element वर add करतो
- Clear → सगळे elements काढून टाक


 
 */


namespace Learning_C_Sharp
{
    internal class stack_non_Generic_collections
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("Pranav");
            mystack.Push(45);
            mystack.Push(2.54);
            mystack.Push(false);


            foreach(object item in mystack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total Coutn is :" +mystack.Count);
            Console.WriteLine("---------------------------------");
            mystack.Pop();
            foreach (object item in mystack)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

    }
}
