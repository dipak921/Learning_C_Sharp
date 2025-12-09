using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Generic_LinkList
    {
        static void Main(string[] args)
        {
            LinkedList<int> number = new LinkedList<int>();
            number.AddFirst(10); //List :10
            number.AddLast(20); // List : 10->20
            number.AddFirst(5); // List : 5 -> 10 -> 20
            number.AddLast(30); //List:  5 -> 10 -> 20 ->30

            Console.WriteLine("Link List Items");
            foreach(int i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("----------------------Add After --------------------------------");

            var position20 = number.Find(20);
            if(position20 != null)
            {
                number.AddAfter(position20, 25);
            }
            foreach (int i in number)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("----------------------Add Before --------------------------------");
            var position10 = number.Find(10);
            if (position10 != null)
            {
                number.AddBefore(position10, 7);
            }
            foreach (int i in number)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();
        }
    }
}
