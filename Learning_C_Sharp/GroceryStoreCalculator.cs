using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class GroceryStoreCalculator
    {
        // Class to represent each grocery item
        public class GroceryItem
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public double GetTotal()
            {
                return Price * Quantity;
            }
        }
        static void Main(string[] args)
        {
            List<GroceryItem> cart = new List<GroceryItem>();
            bool running = true;

            Console.WriteLine("=== Grocery Store Calculator ===");

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. View Cart");
                Console.WriteLine("3. Calculate Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter item name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter item price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter quantity: ");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        cart.Add(new GroceryItem { Name = name, Price = price, Quantity = qty });
                        Console.WriteLine("Item added successfully!");
                        break;
                    case "2":
                        Console.WriteLine("\n--- Cart Items ---");
                        foreach (var item in cart)
                        {
                            Console.WriteLine($"{item.Name} - {item.Quantity} x {item.Price:C} = {item.GetTotal():C}");
                        }
                        break;

                    case "3":
                        double subtotal = 0;
                        foreach (var item in cart)
                        {
                            subtotal += item.GetTotal();
                        }

                        Console.WriteLine($"\nSubtotal: {subtotal:C}");

                        Console.Write("Enter discount percentage (0 if none): ");
                        double discountPercent = Convert.ToDouble(Console.ReadLine());

                        double discountAmount = subtotal * (discountPercent / 100);
                        double total = subtotal - discountAmount;

                        Console.WriteLine($"Discount: {discountAmount:C}");
                        Console.WriteLine($"Total Bill: {total:C}");
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Thank you for using Grocery Store Calculator!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

    }
}
