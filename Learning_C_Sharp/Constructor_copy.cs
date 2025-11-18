using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo
{
    internal class Constructor_copy
    {
        string Name;
        int EmpId;
        int Age;
        int Salary;

        public Constructor_copy(string name, int empid, int ege, int salary)
        {
            Name = name;
            EmpId = empid;
            Age = ege;
            Salary = salary;

        }
        public Constructor_copy(Constructor_copy c)
        {
            this.Name = c.Name;
            this.EmpId = c.EmpId;
            this.Age = c.Age;
            this.Salary = c.Salary;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name : {Name}, Emp_id : {EmpId},Age : {Age}, Salary: {Salary}");
        }
        static void Main(string[] args)
        {
            Constructor_copy s1 = new Constructor_copy("Dinesh", 101, 21, 20000);

            s1.DisplayDetails();
            Constructor_copy s2 = new Constructor_copy(s1);
            s2.DisplayDetails();

        }
    }
}