using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class function_type
    {
        public static void showMessage()
        {
            Console.WriteLine("Welcome Dipak Rode");
        }

        public void showMessage1()
        {
            Console.WriteLine("Hi Dipak");
        }

        // With parameter , no returen
        public static void showMessage2(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        //public void showMessage3(string name1)
        //{
        //    Console.WriteLine("Ram Ram" + name1);
        //}

        // no parameter with retuern values using static
        public static int getNumber()
        {
            return 15;
        }

        // no parameter with retrun value using non static
        public int getNumber1()
        {
            return 25;
        }

        // With parameter with return static
        public static int add(int a, int b)
        {
            return a + b;
        }

        // With parameter with return non- static
        public  int add1(int a, int b)
        {
            return a + b;
        }

        // home work;
        public static int addation(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static int multi(int a, int b)
        {
            return a * b;
        }

        public static int division(int a, int b)
        {
            return a / b;
        }


        // with paramet no return
        public static void subtraction(int a , int b)
        {
            Console.WriteLine("Substraction is" + (a - b) );
        }

        public static  int multipliction()
        {
            Console.WriteLine("enter a number 1 ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2 ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a * b;
        }

        public static void divison1()
        {
            Console.WriteLine("enter a number 1 ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2 ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("division is :" + a / b);

        }

        // Non static
       
        static void Main(string[] args)
        {
            // No parameter no returen using two method with static or non-static

            //function_type.showMessage();


            function_type ft = new function_type();
            //ft.showMessage1();


            //function_type.showMessage2("Mahesh");


            ////function_type.showMessage3("Rambhau");


            //Console.WriteLine("Number is "+ getNumber());


            //Console.WriteLine("Number is " + ft.getNumber1());

            //int sum = add(23,20);
            //Console.WriteLine("Sum is :" + sum);


            //int sum1 = ft.add1(23, 40);
            //Console.WriteLine("Sum is 1 :" + sum1);

            //Console.WriteLine("enter a number 1 ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a number 2 ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int sumof = addation(x, y);
            //Console.WriteLine(sumof);

            //Console.WriteLine("enter a number 1 ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a number 2 ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int mult = multi(a, b);
            //Console.WriteLine(mult);

            //Console.WriteLine("enter a number 1 ");
            //int p = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a number 2 ");
            //int q = Convert.ToInt32(Console.ReadLine());
            //int divi = division(p, q);
            //Console.WriteLine(divi);

            //Console.WriteLine("enter a number 1 ");
            //int r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a number 2 ");
            //int s = Convert.ToInt32(Console.ReadLine());
            //int div = division(x, y);
            //Console.WriteLine(div);

            //Console.WriteLine("enter a number 1 ");
            //int t = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a number 2 ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //subtraction(t,m);

            //int mulResult = multipliction();
            //Console.WriteLine("Multipliction is :" + mulResult);

            function_type.divison1();



            Console.ReadLine();
        }
    }
}
