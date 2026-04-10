using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    class Example
    {
        string name;
        int age;

        public Example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Copy constructor
        public Example(Example e)
        {
            this.name = e.name;
            this.age = e.age;
        }

        public void getData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }


    internal class Copy_Constructor
    {
        static void Main(string[] args)
        {
            Example obj = new Example("John", 25);
            obj.getData();
            Console.WriteLine("--------------- Copy Constructor -----------------------");
            Example obj2 = new Example(obj); // Using copy constructor
            obj2.getData();



            Console.ReadLine();
        }
    }
}
