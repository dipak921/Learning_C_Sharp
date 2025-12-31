using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class abc
    {
        public abc()
        {
            Console.WriteLine("Default");
        }
        public abc(string name)
        {
            Console.WriteLine($"Student Name: {name}");
        }

        public abc(string name, int age)
        {
            Console.WriteLine($"Student Name: {name}, Age: {age}");
        }

        public abc(string name, int age, string course)
        {
            Console.WriteLine($"Student Name: {name}, Age: {age}, Course: {course}");
        }
    }
    internal class Constrctor_overloading
    {
        static void Main(string[] args)
        {
            abc a = new abc();
            abc a1 = new abc("Nilesh");
            abc a2 = new abc("Ram", 25);
            abc a3 = new abc("Vishal", 22, "MBA");



            Console.ReadLine();
        }
    }
}
