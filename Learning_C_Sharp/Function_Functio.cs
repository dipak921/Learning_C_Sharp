using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Method_Function
    {
        public void show() //non-static / instant method /non parameter
        {
            Console.WriteLine("Welcome");
        }

        public static void show1() //non-static / instant method /non parameter
        {
            Console.WriteLine("Welcome");
        }
        static void Main(string[] args)
        {
            Method_Function mf = new Method_Function();
            mf.show();
            Method_Function.show1();


            Console.ReadLine();

        }

    }
}