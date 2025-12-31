using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Student1002
    {
        public int id;
        public string name;

        public Student1002()
        {
            id = 101;
            name = "Dipak";
            Console.WriteLine("Default Constructor Called.");
        }
        public void Display()
        {
            Console.WriteLine("Id :" + id + " Name :"+ name);
        }
            
    }
    internal class Constructor_Default
    {
        static void Main(string[] args)
        {
            Student1002 s = new Student1002();
            Console.WriteLine("Student Detail :");
            s.Display();




            Console.ReadLine();
        }
    }
}
