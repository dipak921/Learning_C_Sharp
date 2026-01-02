using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Person01
    {
        public string Name;
        public int Age;

        public Person01(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"Name is : {Name}, Age is : {Age}");
        }
    }

    // Child class
    class Employee0111 : Person01
    {
        public int empId;
        public double empSalary;

        public Employee0111(string name, int age, int empId, double empSalary)
            : base(name, age)   // Calling base class constructor
        {
            this.empId = empId;
            this.empSalary = empSalary;
            Console.WriteLine($"Employee Id : {empId}, Salary : {empSalary}");
        }
    }
    internal class Inheritance_revision
    {
        static void Main(string[] args)
        {
            Employee0111 e = new Employee0111("Dipak", 23, 101, 45000);

            Console.ReadLine();




            Console.ReadLine();
        }
    }
}

