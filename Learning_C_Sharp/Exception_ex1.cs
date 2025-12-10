using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Exception_ex1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter First Number :");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Second Number :");
            //int num2 = int.Parse(Console.ReadLine());

            //int result = num1 / num2;
            //Console.WriteLine("Division is :"+result);

            try
            {
                Console.WriteLine("Enter First Number :");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Second Number :");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Division is :" + result);
            }
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Error : You can not Devide by Zero...");
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Some Error Exception..." + ex.Message);
            }




            Console.ReadLine();
        }
    }
}
