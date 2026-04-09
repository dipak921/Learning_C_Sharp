using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class Constructor
    {

        public Constructor() 
        {
            Console.WriteLine("This is a constructor.");
        }

        int employeeId;
        string employeeName;
        int Age;
        public Constructor(int id, string name, int age) // Parameterized constructor
        {
            employeeId = id;
            employeeName = name;
            Age = age;
        }

        public int getEmployeeId()
        {
            return employeeId;
        }
        public string getEmployeeName() {
            return employeeName;
        }   
        public int getAge() {
            return Age;
        }

        static void Main(string[] args)
        {
            // Creating an object of the class to call the constructor
            Constructor obj = new Constructor();
            Constructor obj2 = new Constructor(1, "John Doe", 30); // Using parameterized constructor
            Constructor obj3 = new Constructor(2, "Jane Smith", 25); // Using parameterized constructor

            Console.WriteLine("Employee ID: " + obj2.getEmployeeId());
            Console.WriteLine("Employee Name: " + obj2.getEmployeeName());
            Console.WriteLine("Employee Age: " + obj2.getAge());



            Console.WriteLine("------------------------------------");
            Console.WriteLine("Employee ID: " + obj3.getEmployeeId());
            Console.WriteLine("Employee Name: " + obj3.getEmployeeName());
            Console.WriteLine("Employee Age: " + obj3.getAge());





           



            Console.ReadLine();
        }
    }
}
