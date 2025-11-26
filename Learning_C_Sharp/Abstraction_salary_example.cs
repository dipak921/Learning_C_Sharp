using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//         ABSTRACTION 
// --> Abstraction is one of the principle of object oriented programing.
// It is used to display only nesessary and essential features of an object to outside the world.
// --> Means displaying what is necessary and encapsulate the unnecessary things to outside the world.
// Hiding can be achieved by using "private" access modifier.
//--> Abstraction is process of hiding the implementation details from the user only the functionality will be provided to the user.
//--> In other words, the user will have the information on what the object does instead of how it does it .
//--------------NOTES
//--> Outside the world menas when we use reference of object then it will show only necessary methods
//and properties (ABSTRACTION) and hide methods which are not necessary (ENCAPSULATION).

// Abstraction
// 1. Abstraction is "To represent the essential feature without representing the backgound details.
// 2. Abstraction lets you focus on what the object does instead of how it does it.
// 3. Abstraction provides you a generalized view of your classes or objects by providing relevant information
// 4. Abstraction is the process of hiding the working style of an object, and showing the information
// of an object in an understandable manner.


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
