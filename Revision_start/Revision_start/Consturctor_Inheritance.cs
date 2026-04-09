using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    class Base
    {
        public Base(string message)
        {
            Console.WriteLine("Base class constructor called with message: " + message);
        }
    }

    class Derived : Base
    {
        public Derived() : base("Hello from Derived") // Explicitly calling the base class constructor
        {
            Console.WriteLine("Derived class constructor called.");
        }
    }

    internal class Consturctor_Inheritance
    {
        public static void Main(string[] args)
        {
            Derived derived = new Derived();
            






            Console.ReadLine();
        }
    }
}
