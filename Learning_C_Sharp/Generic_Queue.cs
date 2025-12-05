using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 - Namespace: System.Collections.Generic
- Type: Generic collection (strongly typed)
- Order: FIFO (First-In-First-Out)
- Advantage over non-generic Queue:
- Type safety (no boxing/unboxing)
- Better performance
- Compile-time error detection

  Common Methods (Closely tied to properties)
- Enqueue(T item) → Adds an element at the end.
- Dequeue() → Removes and returns the first element.
- Peek() → Returns the first element without removing it.
- Contains(T item) → Checks if an element exists.
- Clear() → Removes all elements.
- ToArray() → Copies elements to a new array.

 */
namespace Learning_C_Sharp
{
    internal class Generic_Queue
    {
        static void display(Queue<string> Name)
        {
            foreach (string item in Name)
            {
                Console.WriteLine("Item: " + item);
            }
        }
        static void Main(string[] args)
        {
            Queue<string> Name = new Queue<string>();


            Name.Enqueue("Dipak");
            Name.Enqueue("Rohit");
            Name.Enqueue("Pranit");
            Name.Enqueue("Ganesh");
            Name.Enqueue("Rakesh");
            Name.Enqueue("Pranav");
            display(Name);
            Console.WriteLine("-----------------Top name---------------");
            
            Console.WriteLine("Top element: " + Name.Peek());

            Console.WriteLine("--------------Dequeue------------------");
            Console.WriteLine("Removed: " + Name.Dequeue());
            Console.WriteLine("Removed: " + Name.Dequeue());
            Console.WriteLine("--------------After Remove--------------");
            display(Name);
            Console.WriteLine("---------------Contains Element-----------------");
            Console.WriteLine("The Contains is Dipak :" + Name.Contains("Dipak"));

            //Console.WriteLine("---------------Reverse print Element-----------------");
            //Name.Reverse();
            //display(Name);

            Console.WriteLine("---------------Count-----------------");

            Console.WriteLine("Count: " + Name.Count);

            Console.WriteLine("---------------Clear Element-----------------");
            Name.Clear();
            display(Name);

            Console.WriteLine("************* Atfer Clear Coutn ***************");
            Console.WriteLine("Count: " + Name.Count);







            Console.ReadLine();
        }
    }
}
