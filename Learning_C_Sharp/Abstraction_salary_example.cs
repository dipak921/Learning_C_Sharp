using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Employee
    {
        public string name;
        public int age;

        public double GrossSalary;
        double taxDeduction = 0.1;
        double netSalary;
        
        public Employee(string name, int age, double GrossSalary) 
        { 
            this.name = name;   
            this.age = age;
            this.GrossSalary = GrossSalary;
        }
        private void CalculateSalary()
        {
            if(GrossSalary > 30000)
            {
                netSalary = GrossSalary - (taxDeduction * GrossSalary);
                Console.WriteLine($"Your Net Salary {netSalary}" );
            }else
            {
                Console.WriteLine($"your net salary {GrossSalary}");
            }
        }
        public void showEmployeeDetails()
        {
            Console.WriteLine($"Employee Name :{name}");
            Console.WriteLine($"Employee Age :{age}");
            this.CalculateSalary();
        }
    }
    internal class Abstraction_salary_example
    {
        static void Main(string[] args) 
        {
            Employee e1 = new Employee("Dipak", 22, 40000);
            e1.showEmployeeDetails();

            Console.WriteLine("-------------------------------------------------------------");

            Employee e2 = new Employee("Jayant",62, 28000);
            e2.showEmployeeDetails();

            Console.WriteLine("-------------------------------------------------------------");

            Employee e3 = new Employee("Ramesh", 42, 63000);
            e3.showEmployeeDetails();


            Console.ReadLine();
        }
    }
}
