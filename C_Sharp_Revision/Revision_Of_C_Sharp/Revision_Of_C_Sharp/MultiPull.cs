using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revision_Of_C_Sharp
{
    internal class MultiPull
    {
        //static void DoSomeWork(object state)
        //{
        //    Console.WriteLine($"Work started for : {state} Thread ID : {Thread.CurrentThread.ManagedThreadId}");
        //    Thread.Sleep(1000);

        //    Console.WriteLine($"Wrok complte for :{state}");

        //}


        // Lock Keyword

        static int count = 0; // shared var
        static object lockObj = new object();

        static void Increment()
        {
            for(int i = 0; i <5;  i++)
            {
                lock(lockObj)
                {
                    count++;
                    Console.WriteLine($"Counter : {count}  Thread Id : {Thread.CurrentThread.ManagedThreadId}");
                }
                Thread.Sleep(2000);
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Main Started ");
            //ThreadPool.QueueUserWorkItem(DoSomeWork, "Task1");
            //ThreadPool.QueueUserWorkItem(DoSomeWork, "Task2");
            //ThreadPool.QueueUserWorkItem(DoSomeWork, "Task3");


            //Console.WriteLine("Main Done");
            //Thread.Sleep(3000);



            // Lock Keywork
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();


            Console.WriteLine("Final Count :" + count);



            Console.ReadLine();
        }
    }
}
