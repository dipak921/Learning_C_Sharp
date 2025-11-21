using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class billing
    {
        static void Main()
        {
            double total = 0;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Simple Billing Menu ---");
                Console.WriteLine("1. Tea - 10");
                Console.WriteLine("2. Coffee - 15");
                Console.WriteLine("3. Sandwich - 30");
                Console.WriteLine("4. Exit & Print Bill");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        total += 10;
                        Console.WriteLine("Tea added. Current total: ₹{0:F2}", total);
                        break;
                    case 2:
                        total += 15;
                        Console.WriteLine("Coffee added. Current total: ₹{0:F2}", total);
                        break;
                    case 3:
                        total += 30;
                        Console.WriteLine("Sandwich added. Current total: ₹{0:F2}", total);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("\n--- Final Bill ---");
            Console.WriteLine("Total Amount: ₹{0:F2}", total);
            Console.WriteLine("Thank you for shopping!");
        }
    }
}


