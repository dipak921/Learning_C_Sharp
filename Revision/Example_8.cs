using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_8
    {
        static void Ex1()
        {
            // Jagged array: rows with different number of seats
            string[][] seats = new string[3][];

            seats[0] = new string[] { "A1", "A2", "A3" };        // Row 1: 3 seats
            seats[1] = new string[] { "B1", "B2", "B3", "B4" };  // Row 2: 4 seats
            seats[2] = new string[] { "C1", "C2" };              // Row 3: 2 seats

            for (int i = 0; i < seats.Length; i++)
            {
                Console.Write("Row " + (i + 1) + " Seats: ");
                foreach (string seat in seats[i])
                {
                    Console.Write(seat + " ");
                }
                Console.WriteLine();
            }
        }

        static void Ex2()
        {
            string[][] employeeProjects = new string[3][];

            employeeProjects[0] = new string[] { "HR System", "Payroll" };             
            employeeProjects[1] = new string[] { "E-Commerce", "Mobile App", "CRM" }; 
            employeeProjects[2] = new string[] { "Inventory" };                        

            for (int i = 0; i < employeeProjects.Length; i++)
            {
                Console.Write("Employee " + (i + 1) + " Projects: ");
                foreach (string project in employeeProjects[i])
                {
                    Console.Write(project + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. For One Example  :");
            Console.WriteLine("2. For Second Example :");
            int ex = Convert.ToInt32(Console.ReadLine());

            if (ex == 1)
            {
                Ex1();
            }
            else if (ex == 2)
            {
                Ex2();
            }
            else { Console.WriteLine("Enter Correct Option"); }



            Console.ReadLine();
        }
    }
}
