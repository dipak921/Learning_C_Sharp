using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Company
    {
        public static string companyName;
        public int employeeId;

        static Company()
        {
            companyName = "Tata Motors";
            Console.WriteLine("Static Constrcotr called..");
        }
        public Company(int employeeId)
        {
            this.employeeId = employeeId;
            Console.WriteLine("Parmetrized Constrctor Callded");
        }
        public void Display()
        {
            Console.WriteLine("Company Name :" + companyName);
            Console.WriteLine("Emp Id :" + this.employeeId);
        }
    }
    internal class Constructor_static
    {
        static void Main(string[] args)
        {
            Company c = new Company(101);
            c.Display();
            Console.WriteLine("-------------------------------------------------");
            Company c1 = new Company(102);
            c1.Display();



            Console.ReadLine();
        }
    }
}
