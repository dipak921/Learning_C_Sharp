using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class stack2_non_Generic_collection
    {
        static void Main(string[] args)
        {
            Stack mystack1 = new Stack();
            mystack1.Push("Dipak");
            mystack1.Push("Jayant");
            mystack1.Push("Pranit");
            mystack1.Push("Om");
            mystack1.Push("Ramesh");

            foreach (object m in mystack1)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(mystack1.Count);
            Console.WriteLine("-----------------------------------------");

            mystack1.Pop();

            foreach (object m in mystack1)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(mystack1.Count);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\n Top of Stack (peek)" + mystack1.Peek());
            Console.WriteLine(" Rmoving :" + mystack1.Pop());
            Console.WriteLine(mystack1.Count);

            mystack1.Push("Lakhan");
            foreach (object m in mystack1)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Contains 'Lakhan' " + mystack1.Contains("Lakhan"));

            mystack1.Clear();
            Console.WriteLine("Total Count "+mystack1.Count);

            Console.ReadLine();
        }
    }
}
