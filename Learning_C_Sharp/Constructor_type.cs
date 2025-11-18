using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Constructor_type
    {
        public Constructor_type() // Default Constructor
        {
            Console.WriteLine("Default Construcotr");
        }

        string Name;
        int EmpId;
        int Age;
        int Salary;
        public Constructor_type(string name, int empid, int age, int salary)
        {
            Name = name;
            EmpId = empid;
            Age = age;
            Salary = salary;
        }
        public string getName()
        {
            return Name;
        }
        public int getEmpId()
        {
            return EmpId;
        }
        public int getAge()
        {
            return Age;
        }
        public int getSalary()
        {
            return Salary;
        }
        //Second Method
        public string GetDetails()
        {
            return $"Name :{Name}, EmpId :{EmpId}, Age :{Age}, Salary :{Salary}";
        }
        //Third Method
        public void DisplayDetail()
        {
            Console.WriteLine($"Name :{Name}, EmpId :{EmpId}, Age :{Age}, Salary :{Salary}");
        }
        static void Main(string[] args)
        {
            Constructor_type constrct = new Constructor_type(); // Object Create default constrctor

            //Frist Method
            Constructor_type s1 = new Constructor_type("dipak",101,22,32000);
            
            Console.WriteLine($"Name is :{s1.getName()}");
            Console.WriteLine($"EmpId is :{s1.getEmpId()}");
            Console.WriteLine($"Age is :{s1.getAge()}");
            Console.WriteLine($"Salary is :{s1.getSalary()}");
            Console.WriteLine($"---------------------------------------");

            Console.WriteLine($"Name is :{s2.getName()}");
            Console.WriteLine($"EmpId is :{s2.getEmpId()}");
            Console.WriteLine($"Age is :{s2.getAge()}");
            Console.WriteLine($"Salary is :{s2.getSalary()}");


            Console.WriteLine($"------------------Second Method---------------------");
            Console.WriteLine($"Information is  :{s1.GetDetails()}");
            Console.WriteLine($"Information is  :{s2.GetDetails()}");

            Console.WriteLine($"------------------Third Method---------------------");
            s1.DisplayDetail();
            s2.DisplayDetail();



            Console.ReadLine();
        }
    }

}
