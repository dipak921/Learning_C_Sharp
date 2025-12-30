using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    internal class Example_2
    {
        static void Ex1()
        {
            /*1. Arithmetic Operators (+ - * / %)
Problem Statement
A shopping cart system calculates the total bill amount.
Given the price of an item and quantity purchased, calculate:
Total price
Discount of 10% if total exceeds ₹1000
Final payable amount
👉 Use arithmetic operators for calculations.*/
            Console.Write("Enter price of item: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter quantity purchased: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            decimal totalPrice = price * quantity;
            decimal discount = 0;
            if (totalPrice > 1000)
            {
                discount = totalPrice * 10 / 100; // 10% discount
            }
            decimal finalAmount = totalPrice - discount;
            Console.WriteLine("\n--- Shopping Cart Bill ---");
            Console.WriteLine($"Total Price: ₹{totalPrice}");
            Console.WriteLine($"Discount: ₹{discount}");
            Console.WriteLine($"Final Payable Amount: ₹{finalAmount}");
        }


        static void Ex2()
        {
            // Step 1: Define correct credentials
            string correctUsername = "admin";
            string correctPassword = "12345";

            // Step 2: Take user input
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Step 3: Validate using logical operators
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("\nLogin Successful ");
            }
            else
            {
                Console.WriteLine("\nLogin Denied");
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
