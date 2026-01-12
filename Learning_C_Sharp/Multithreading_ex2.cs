using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Multithreading_ex2
    {
        static void LongRunningTask()
        {
            try
            {
                for(int i = 1; i <=100; i++)
                {
                    Console.WriteLine("Working....." + i);
                    Thread.Sleep(200);
                }
            }
            catch(ThreadAbortException ex)
            {
                Console.WriteLine("Thread was Aborted");
                Thread.ResetAbort();
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(LongRunningTask);
            t.Start();

            Console.WriteLine("Aborting The Thread.");
            t.Abort(); // forcefully stop the thread

            t.Join(); // wait for the thread Exit.

            //Console.WriteLine("Mani Thread Ends");







            Console.ReadLine();
        }
    }
}
