using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\n============================");
            //Console.WriteLine("For Loop");
            //Console.WriteLine("============================");

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine.(i);
            //}


            // sum of first 10 natural number 
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine($"Total sum of natural number : {sum}");



            //for (int i = 2; i <= 20;i = i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10;i++)
            //{
            //    Console.WriteLine($"{a} X {i} = {i*a}");
            //}

            //Console.WriteLine("\n============================");
            //Console.WriteLine("Nested For Loop");
            //Console.WriteLine("============================");

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.Write($"{i * j}\t");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("\n============================");
            //Console.WriteLine("While Loop");
            //Console.WriteLine("============================");
            //int i = 0;
            //while(i<=5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            // even number pirnt using while loop
            //int i = 2;
            //while (i <= 20)
            //{
            //    Console.WriteLine(i);
            //    i += 2;
            //}


            // Console.WriteLine("Enter a number");
            // int a = Convert.ToInt32(Console.ReadLine());
            // int i = 0;
            // int sum = 0;
            // while (i <= a)
            // {
            //     sum = sum + i;
            //     i++;    
            // }

            //Console.WriteLine($"SUM OF N NUMBER : {sum}");

            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //int rev = 0;

            //while (a > 0)
            //{
            //    int digit = a % 10;
            //    rev = (rev * 10) + digit;
            //    a  /= 10;
            //}
            //Console.WriteLine($"Reverse number is : {rev}");

            Console.WriteLine("\n============================");
            Console.WriteLine("While Loop");
            Console.WriteLine("============================");
            //int i = 6;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 5);



            //string confirm;
            //do
            //{
            //    Console.WriteLine("Enter a Frist number");
            //    int a = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Enter a Second number");
            //    int b = Convert.ToInt32(Console.ReadLine());

            //    int add = a + b;
            //    Console.WriteLine($"Addition result is :{add}");

            //    Console.WriteLine("Do you want to really Continue (yes / no)");
            //     confirm = Console.ReadLine();
            //} while(confirm == "yes");


            string a;
            do
            {
                Console.WriteLine("Enter a number for Addtion 1");
                Console.WriteLine("Enter a number for Substraction 2");
                 a = Console.ReadLine();

                if (a == "1")
                {
                    Console.WriteLine("Enter a Frist number");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter a Second number");
                    int y = Convert.ToInt32(Console.ReadLine());

                    int add = x + y;
                    Console.WriteLine($"Addition result is :{add}");
                }
                else if (a == "2")
                {
                    Console.WriteLine("Enter a Frist number");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter a Second number");
                    int y = Convert.ToInt32(Console.ReadLine());

                    int sub = x - y;
                    Console.WriteLine($"Substraction result is :{sub}");
                }

                else if (a == "3")
                {
                    Console.WriteLine("Existing");
                }
                else
                {
                    Console.WriteLine("In vaild Choise");
                }
            } while (a != "3");





            Console.ReadLine();
        }
    }
}
