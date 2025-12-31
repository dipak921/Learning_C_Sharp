using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Emp
    {
        public int empId;
        public string empName;
        public double salary;

        public Emp(int empId, string empName, double salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
            Console.WriteLine("Parameterized Constructor Called");
        }
        public void Display()
        {
            Console.WriteLine("Emp Id :" + empId);
            Console.WriteLine("Emp Name :" + empName);
            Console.WriteLine("Salary :" + salary);
        }
    }
    internal class Constructor_Parameterize
    {
        
        static void Main(string[] args)
        {

            Emp e1 = new Emp(101, "Ram", 15000);
            Emp e2 = new Emp(102, "Dipak", 25000);

            Console.WriteLine("Employee Detail :");
            e1.Display();
            e2.Display();



            Console.ReadLine();
        }
    }
}
