using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revision_Of_C_Sharp
{
    internal class ThreadProgram
    {

        static void PrintNum()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number : {i}");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(PrintNum);

            t1.Start();



            Console.WriteLine("Main Thread is Running....");



            Console.ReadLine();
        }
    }
}
