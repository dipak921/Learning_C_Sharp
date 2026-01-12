using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Multithreading
    {
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Function One Call :" + i);
            }
        }
        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Function Two Call :" + i);
                Console.WriteLine("Thread is going t sleep for 10 sec");
                if (i == 10)
                {
                    Thread.Sleep(1000);
                }
            }
        }
        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Function Three Call :" + i);
            }
        }
        static void Main(string[] args)
        {
            //Multithreading.func1();
            //Multithreading.func2();
            //Multithreading.func3();

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);
            t1.Start();
            t2.Start();
            t3.Start();



            Console.ReadLine();
        }
    }
}
