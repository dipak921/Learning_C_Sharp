using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     ---- Constant ---
    it is special identifier whose value can not be changed. 
    syntax: const data_type constant_name = value;

    Literal : it is the value of variable and constand
    string literal: "Hello World", "Welcome to C#"
     */


    /*
     -- Assignment / Home Work --
    1. WAP  to calulate simple interest and compound interest
    2. WAP to calculate area of circle and Triangle
    3. WAP to convert feet to inch and inch to feet
    4. WAP to reverse a number three digits number
     */



    internal class Constant
    {
        // write to swap two numbers using static global variable
        void Swap()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before Swaping : a = {0}, b = {1}", a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: a = {0}, b = {1}", a, b);
        }

        static void Main(string[] args)
        {
            const string company_name = "Microsoft";

            // company_name = "Google"; // error: cannot assign a value to a constant variable
            Console.WriteLine("Company Name is : {0}", company_name);

            // write to swap two numbers using static global variable
            Constant c = new Constant();
            c.Swap();



            Console.ReadLine();
        }
    }
}
