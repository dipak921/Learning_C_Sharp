using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acc1; //------------

namespace acc2
{
    //internal class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("This is second Project");
    //        class1 obj = new class1();
    //        obj.show1();

    //        Console.ReadLine();
    //    }
    //}

    internal class Program2 : class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is second Project- using derived class");
            Program2 obj = new Program2();
            obj.show1();

            Console.ReadLine();
        }
    }



}
