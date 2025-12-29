using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
    internal class Example_1
    {
        static void example()
        {
            /*Employee Salary Calculation
- Create a program that stores:
- Employee ID (int)
- Employee Name (string)
- Basic Salary (double)
- Is Permanent Employee (bool)
- Calculate Net Salary after deducting 10% tax if permanent, otherwise 5%.
- Display the details in a formatted output.
*/

            int EmployeeId = 101;
            string EmpName = "Dipak";
            double Salary = 35000;
            bool isPermanet = false;

            if (isPermanet)
            {
                double inHand = Salary - (Salary * 0.10);
                Console.WriteLine($"Employee ID is : {EmployeeId} and Name is {EmpName} Your Salary is {inHand}");
            }
            else
            {
                double inHand = Salary - (Salary * 0.05);
                Console.WriteLine($"Employee ID is : {EmployeeId} and Name is {EmpName} Your Salary is {inHand}");
            }

        }

        static void example2()
        {
            /*Array of Products
- Create an array of 5 products with:
- Product ID (int)
- Product Name (string)
- Price (decimal)
- Print the product with the highest price.
             */
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. For One Example  :");
            Console.WriteLine("2. For Second Example :");
            int ex = Convert.ToInt32(Console.ReadLine());

            if (ex == 1)
            {
                example();
            }
            else if(ex == 2) 
            {

                Product[] products = new Product[5];
                products[0] = new Product { ProductID = 101, ProductName = "Laptop", Price = 55000.75m };
                products[1] = new Product { ProductID = 102, ProductName = "Smartphone", Price = 30000.50m };
                products[2] = new Product { ProductID = 103, ProductName = "Tablet", Price = 20000.00m };
                products[3] = new Product { ProductID = 104, ProductName = "Headphones", Price = 2500.99m };
                products[4] = new Product { ProductID = 105, ProductName = "Smartwatch", Price = 12000.25m };

                Product highestPriceProduct = products[0];
                foreach (var product in products)
                {
                    if (product.Price > highestPriceProduct.Price)
                    {
                        highestPriceProduct = product;
                    }
                }

                Console.WriteLine("Product with Highest Price:");
                Console.WriteLine($"ID: {highestPriceProduct.ProductID}");
                Console.WriteLine($"Name: {highestPriceProduct.ProductName}");
                Console.WriteLine($"Price: {highestPriceProduct.Price}");
            }
            else { Console.WriteLine("Enter Correct Option"); }



            Console.ReadLine();
        }
    }
}
