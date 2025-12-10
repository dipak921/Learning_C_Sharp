using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Learning_C_Sharp
{
    internal class Exception_ex2
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] arr = { 10, 20, 30, 40 };
            //    Console.WriteLine(arr[4]);
            //}
            //catch (Exception ed)
            //{
            //    Console.WriteLine("Wrong value "+ ed.Message);
            //}

            try
            {
                Console.WriteLine("Enter Your Name :");
                string name = Console.ReadLine();

                Console.WriteLine(name);
                if(name == null)
                {
                    Console.WriteLine("enter name");
                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("Exception is :" + ex.Message);
            }

            

            Console.ReadLine();
        }
    }
}
