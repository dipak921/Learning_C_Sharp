using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome dot net developer");
            //Console.WriteLine("Enter Your Name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Your Address");
            //string Address = Console.ReadLine();

            //// three type of concate 
            ////Console.Write("My Name is " + name + "My address is " + Address); // Cocatination

            ////Console.WriteLine("my name is {0} and my address is {1}",name, Address); // Placeholder 

            //Console.WriteLine($"my name is {name} and my address is {Address}"); // strin interpolatin

            Console.WriteLine("Entre a no. 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre a no. 2");
            int num2 = int.Parse(Console.ReadLine()); // convert read line to  int read line is 

            int total = num1 + num2;
            Console.WriteLine($"Sum of {num1} and {num2} = {total}");





            Console.ReadLine();
        }
    }
}
