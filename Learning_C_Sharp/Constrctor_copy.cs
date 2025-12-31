using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learning_C_Sharp
{
    class student1003
    {
        public int id;
        public string name;

        public student1003(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public student1003(student1003 s)
        {
            this.id = s.id;
            this.name = s.name;
            Console.WriteLine("Copy Constructor Called");
        }
         
        public void Display()
        {
            Console.WriteLine("Id is :" +this.id);
            Console.WriteLine("Name :" + this.name);
        }
    }
    internal class Constrctor_copy
    {
        static void Main(string[] args)
        {
            student1003 s1 = new student1003(101,"Pandurang");
            Console.WriteLine("Original Object");
            s1.Display();

            // Copy constrctor
            student1003 s2 = new student1003(s1);
            Console.WriteLine("Copied Object");
            s2.Display();



            Console.ReadLine();
        }
    }
}
