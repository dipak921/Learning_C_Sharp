using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acc1
{
    public class class1
    {
        public void show1()
        {
            Console.WriteLine("Accesinng Public Method");
        }
        //public void show2() // current class
        //{
        //    class1 obj = new class1();
        //    obj.show2();
        //    //Console.WriteLine("Accesinng Public Method");
        //}
    }
    public class Program1 : class1
    {
        static void Main(string[] args)
        {
            //class1 obj = new class1();
            //obj.show1();
            //-----------------------------------------------------------------------

            Program1 pg = new Program1();
            pg.show1();

            Console.ReadLine();
        }
    }
}
