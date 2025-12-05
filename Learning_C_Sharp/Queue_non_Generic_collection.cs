using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * What is non generic queue
 -->A Queue is a First-In-First-Out (FIFO) collection: the first element added is the first one removed.
    ---- --Key Points----------
- Enqueue() → adds items.
- Dequeue() → removes first item.
- Peek() → shows first item without removing.
- Count → gives total items.

 */


namespace Learning_C_Sharp
{
    internal class Queue_non_Generic_collection
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
