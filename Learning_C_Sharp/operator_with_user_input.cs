using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class @operator_with_user_input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\n============================");
            //Console.WriteLine("Arithmatic Operator");
            //Console.WriteLine("============================");

            //Console.WriteLine($"a + b = {a + b}"); // addtion
            //Console.WriteLine($"a - b = {a - b}"); // substraction 
            //Console.WriteLine($"a * b = {a * b}"); // Multiiplication
            //Console.WriteLine($"a / b = {a / b}"); // Division
            //Console.WriteLine($"a % b = {a % b}"); // Moudule


            //Console.WriteLine("\n============================");
            //Console.WriteLine("Relation Operator");
            //Console.WriteLine("============================");

            //Console.WriteLine($"a == b = {a == b}"); // Equal to
            //Console.WriteLine($"a != b = {a != b}"); // Not Equal to 
            //Console.WriteLine($"a > b = {a > b}"); // Grater Than
            //Console.WriteLine($"a < b = {a < b}"); // Less than
            //Console.WriteLine($"a >= b = {a >= b}"); // Greater Than equal to 
            //Console.WriteLine($"a <= b = {a <= b}"); // Less than Equal to 

            //Console.WriteLine("\n============================");
            //Console.WriteLine("Logical Operator");
            //Console.WriteLine("============================");
            //bool x = (a > 0);
            //bool y = (b > 0);

            //Console.WriteLine($"x && y = {x && y}");
            //Console.WriteLine($"x || y = {x || y}");
            //Console.WriteLine($"!x = {!x}");
            //Console.WriteLine("============================");

            //Console.WriteLine("\n============================");
            //Console.WriteLine("Assignment Operator");
            //Console.WriteLine("============================");

            //int c = a;
            //c += b;
            //Console.WriteLine($"c +=b : {c}");
            //c -= b;
            //Console.WriteLine($"c -=b : {c}");
            //c *= b;
            //Console.WriteLine($"c *=b : {c}");
            //c /= b;
            //Console.WriteLine($"c /=b : {c}");
            //Console.WriteLine("============================");

            //Console.WriteLine("\n============================");
            //Console.WriteLine("Unary Operator");
            //Console.WriteLine("============================");

            //int num = a;
            //Console.WriteLine($"num++ = {num++}");
            //Console.WriteLine($"++num = {++num}");
            //Console.WriteLine($"num-- = {num--}");
            //Console.WriteLine($"--num = {--num}");
            //Console.WriteLine("============================");

            //Console.WriteLine("\n============================");
            //Console.WriteLine("Bitwise Operator");
            //Console.WriteLine("============================");
            //Console.WriteLine($"a & b = {a & b}");
            //Console.WriteLine($"a | b = {a | b}");
            //Console.WriteLine($"a ^ b = {a ^ b}");
            //Console.WriteLine($"~a = {~a}");
            //Console.WriteLine($"a << b = {a << 1}");
            //Console.WriteLine($"a >> b = {a >> 1}");
            //Console.WriteLine("============================");

            Console.WriteLine("\n============================");
            Console.WriteLine("Ternary Operator");
            Console.WriteLine("============================");

            string result = (a < b) ? "a is grater than b" : "b is greather than a";
            Console.WriteLine(result);




            Console.ReadLine(); 
        }
    }
}
