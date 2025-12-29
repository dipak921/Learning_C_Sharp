using System;
using System.Collections.Generic;

class menu
{
    static void Main()
    {
        Dictionary<int, (string Item, double Price)> menu = new Dictionary<int, (string, double)>
        {
            {1, ("Pizza", 250)},
            {2, ("Burger", 120)},
            {3, ("Pasta", 180)},
            {4, ("Coffee", 80)},
            {5, ("Ice Cream", 100)}
        };

        List<(string Item, double Price)> orderList = new List<(string, double)>();
        double total = 0;
        int choice;

        Console.WriteLine("=== Welcome to Dipak's Menu Ordering System ===");
        do
        {
            Console.WriteLine("\nMenu:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}. {item.Value.Item} - ₹{item.Value.Price}");
            }
            Console.WriteLine("6. Finish Order");

            Console.Write("\nEnter your choice: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (menu.ContainsKey(choice))
                {
                    var selected = menu[choice];
                    orderList.Add(selected);
                    total += selected.Price;
                    Console.WriteLine($"{selected.Item} added to your order.");
                }
                else if (choice == 6)
                {
                    Console.WriteLine("\nOrder finished.");
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

        } while (choice != 6);

        Console.WriteLine("\n=== Order Summary ===");
        foreach (var item in orderList)
        {
            Console.WriteLine($"{item.Item} - ₹{item.Price}");
        }
        Console.WriteLine($"Total Amount: ₹{total}");
        Console.WriteLine("Thank you for ordering!");
    }
}