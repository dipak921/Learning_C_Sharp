using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
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
