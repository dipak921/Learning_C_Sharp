using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class student123
    {
        public string name;
        public int marks;
        public int age;
    }
    internal class lambda_expression
    {
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        // SAQURE FUNCTION
        static int squre(int x)
        {
            return x * x;
        }

        // message
        static void msg()
        {
            Console.WriteLine("Hello SirJi ");
        }
        static void Main(string[] args)
        {
            // USING FUNCTION METHOD
            //Console.WriteLine("Additon is " + Add(1, 2));
            
            // USING LAMBDA METHOD
            Func<int,int, int> add = (x, y) => x + y;
            Console.WriteLine("Additon is " + add(1, 4));

            // using function 
            Console.WriteLine("Squre is :" + squre(3));

            // USING LAMBDA METHOD
            Func<int,int> squre1 = (x) => x * x;
            Console.WriteLine("Squre is :" + squre1(4));

            // using function 
            msg();

            // USING LAMBDA METHOD
            Action msg1 = () => Console.WriteLine("Hello Mam");
            msg1();

            //STRING

            Func<string, string> upper = s => s.ToUpper();
            Console.WriteLine(upper("chande"));

            List<int> number = new List<int>()
            {
                1,2,3,4,5,7,6,8,9,10,11,12
            };

            var evennumber = number.Where(n => n % 2 == 0);
            foreach (int n in evennumber)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------------------------------------");
            List<int> marks = new List<int>()
            {
                30,35,84,96,12,32,14,55,66,14,45
            };
            var passstudent = marks.Where(m => m >= 35);
            foreach (int n in passstudent)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("--------------------------------------------------------");
            List<string> names = new List<string>()
            {
                "ram","sham","krishnna","radha", "rukhumani","sita"
            };
            var upperName = names.Select(n => n.ToUpper());
            foreach (string n in upperName)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("--------------------------------------------------------");
            List<int> numbers1 = new List<int>()
            {
                40,10,45,63,80,90,65,20,30,89
            };
            var ordernumber = numbers1.OrderBy(n=>n);
            foreach (int n in ordernumber)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------- Use another class -------------------------");

            List<student123> students123 = new List<student123>()
            {
                new student123 {name = "Dipak", marks = 24 , age = 45},
                new student123 {name = "Ram", marks = 44, age = 25},
                new student123 {name = "Jayant", marks = 64, age = 23},
                new student123 {name = "Lakhan", marks = 84, age = 17},
                new student123 {name = "Vishal", marks = 66, age = 36}
            };
            var passStudent = students123.Where(s => s.marks >= 35);
            foreach(var n in passStudent)
            {
                Console.WriteLine(n.name);
            }
            Console.WriteLine("-------------------Age is greather than 35 ------------------------------");
            var ageis = students123.Where(s => s.age >= 25);
            foreach (var n in ageis)
            {
                Console.WriteLine(n.name);
            }

            Console.WriteLine("-------------------------------------------------");

            List<int> num = new List<int>()
            {
                10,63,24,26,31,33,87,99,47,64,
            };
            var groups = num.GroupBy(n => n%2==0);
            foreach (var g in groups)
            {
                Console.WriteLine(g.Key ? "Even Numbers" : "Odd Number");
                foreach(var n in g)
                {
                    Console.WriteLine(n);
                }
            }
            Console.WriteLine("-------------------- Descending Order -----------------------------");

            var sorted = num.OrderByDescending(n => n );
            foreach (var g in sorted)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine("-------------------- Sum -----------------------------");
            Console.WriteLine(num.Sum());
            Console.WriteLine(num.Max());
            Console.WriteLine(num.Min());
            Console.WriteLine(num.Average());
            Console.WriteLine(num.Contains(24));

            Console.WriteLine("-------------- Top three print ------------------");
            foreach(var k in num.Take(3))
            {
                Console.WriteLine(k);
            }
            // using secod methoed






            Console.ReadLine();
        }
    }
}
