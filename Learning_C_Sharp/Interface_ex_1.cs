using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    /*
    --------------------- INTERFACES IN C#--------------------
An interface is a contract between itself and any class that implements it.
This contract states that any class that implements the interface will implement the interface's properties, methods and/or events.
    An interface contains no implementation,
only the signatures of the functionality the interface provides. An interface can contain signatures of methods, properties, indexers & events.
The interface defines the 'what' part of the syntactical contract and the deriving classes define the 'how' part of the syntactical contract.
Interfaces define properties, methods, and events, which are the memb of the interface. Interfaces contain only the declaration of the members.
 I the responsibility of the deriving class to define the members. One of the main reason to introduce interfaces is that it can be used in multiple inheritance.
-> An interface contains only abstract members, just like classes interface also contains properties, methods, deregates or events, but only declarations, 
    no implementations.
-> An interface cannot be instantiated but can only be inherited by classes or other interfaces.
-> Interface cannot have fields.
-> An interface is declared using the keyword interface.
-> In C#, by default, all members declared in an interface have public as the access modifier. They don't allow explicit access modifiers.
     
    -----------------IMPLEMENTING AN INTERFACE----------------------
-> An interface is implemented by a class in a way similar to inheriting a class.
-> When implementing an interface in a class, implement all the abstract methods declared in the interface. If all the methods
    are not implemented,the class cannot be compiled.
-> The methods implemented in the class should be declared with the same name and signature as defined in the interface.

     */

    //    "I" is a prefix before employee that refers to an interface.
    //    All member of an interface are public and abstract by default.
    // All members of an interface is "Abstract" by default but after C# 8 we can create method with default implementation.
    // No need of Explicit "Public" Access modifier
    interface IPrinter
    {
        void Print(string doucument, int pages);
        void Scan(string doucument, string format);
    }

    class InkjectPrinter : IPrinter
    {
        public void Print(string doucument, int pages)
        {
            Console.WriteLine($"Inkjet Printing {pages} Pages of {doucument}");
        }
        public void Scan(string doucument, string format)
        {
            Console.WriteLine($"Inkject scanning {doucument} to {format} format..");
        }
    }
    class LaserPrinter : IPrinter
    {
        public void Print(string doucument, int pages)
        {
            Console.WriteLine($"Laser Printing {doucument} Pages of {pages}");
        }
        public void Scan(string doucument, string format)
        {
            Console.WriteLine($"Laser scanning {doucument} to {format} format..");
        }
    }
    class dotmatrix : IPrinter
    {
        public void Print(string doucument, int pages)
        {
            Console.WriteLine($"Dot Matrix Printing {doucument} Pages of {pages}");
        }
        public void Scan(string doucument, string format)
        {
            Console.WriteLine($"DotMatrix scanning {doucument} to {format} format..");
        }
    }
    internal class Interface_ex_1
    {
        static void Main(string[] args)
        {
            IPrinter inkjket = new InkjectPrinter();
            Console.WriteLine("-------------Inkject Printet----------------");
            inkjket.Print("Report .Pdf", 3);
            inkjket.Scan("Adhar card.jpj", "abcd");
            Console.WriteLine("-------------laser Printet----------------");
            IPrinter laser = new LaserPrinter();
            laser.Print("pdf", 6);
            laser.Scan("adhar card", "adhar.jpg");
            Console.WriteLine("-------------Dot Matrix Printet----------------");
            IPrinter dotMat = new dotmatrix();
            dotMat.Print("index", 2);
            dotMat.Scan("Pan card", "pancard.png");


            Console.ReadLine();
        }
    }
}
