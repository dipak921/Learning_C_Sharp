using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Revision_Of_C_Sharp
{
    internal class MultiThread
    {
        static void DownloadData()
        {
            Console.WriteLine("DownLoad Data...");
            Thread.Sleep(2000);
            Console.WriteLine("DownLoad Complted");
        }


        static void ProccessData()
        {
            Console.WriteLine("Process Data...");
            Thread.Sleep(1500);

            Console.WriteLine("Process Complted");
        }

        static void SaveData()
        {
            Console.WriteLine("Saving Data...");
            Thread.Sleep(1000);

            Console.WriteLine("Save Complted");
        }




        static void Main(string[] args)
        {
            Thread t1 = new Thread(DownloadData);
            Thread t2 = new Thread(ProccessData);
            Thread t3 = new Thread(SaveData);

            t1.Start();
            t2.Start();
            t3.Start();

            // Main Thread waits unitil the given thread finishes
            t1.Join();
            t2.Join();
            t3.Join();


            Console.WriteLine("Main Theread is runing....");

            /*
             Thread pull insted of creating manuly dot net give ready made thread
             */



            Console.ReadLine();
        }
    }
}
