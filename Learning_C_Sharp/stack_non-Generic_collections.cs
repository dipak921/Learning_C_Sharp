using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
