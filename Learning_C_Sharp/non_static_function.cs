using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class non_static_function
    {
        public  void addtion()
        {
            Console.WriteLine("enter a number 1 ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2 ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("addtion is" + (a + b));

        }
        public void substraction(int a,int b)
        {
            Console.WriteLine("Substraction is :" + (a - b));
        }

        public int multiplicaton()
        {
            Console.WriteLine("enter a number 1 ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2 ");
            int b = Convert.ToInt32(Console.ReadLine());
            //int c = a * b;
            return a * b;

        }
        static void Main(string[] args)
        {
            //non_static_function ft = new non_static_function();
            //ft.addtion();
            non_static_function obj = new non_static_function();

            Console.WriteLine("enter a number 1 ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2 ");
            int y = Convert.ToInt32(Console.ReadLine());

            function_type.subtraction(x,y);


            int result = obj.multiplicaton();

            //function_type.multiplicaton();


        }
    }

}
