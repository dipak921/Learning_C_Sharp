using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Example2_function_overloading
    {
        public void CaluculatMark(int m1)
        {
            Console.WriteLine("Total Subject 1 :");
            Console.WriteLine("Total Mark :" + m1);
            Console.WriteLine("Average Mark :" + m1);
            Console.WriteLine("----------------------------------------");

        }
        public void CaluculatMark(int m1, int m2)
        {
            int total = m1 + m2;
            int avg = total / 2;
            Console.WriteLine("Total Subject 2 :");
            Console.WriteLine("Total Mark :" + total);
            Console.WriteLine("Average Mark :" + avg);
            Console.WriteLine("----------------------------------------");

        }
        public void CaluculatMark(int m1,int m2,int m3)
        {
            int total = m1 + m2 + m3;
            int avg = total / 3;
            Console.WriteLine("Total Subject 3 :");
            Console.WriteLine("Total Mark :" + total);
            Console.WriteLine("Average Mark :" + avg);
            Console.WriteLine("----------------------------------------");
        }
        static void Main(string[] args)
        {
            Example2_function_overloading m = new Example2_function_overloading();
            m.CaluculatMark(56);
            m.CaluculatMark(56,89);
            m.CaluculatMark(56,85,96);


            Console.ReadLine();
        }
    }
}
