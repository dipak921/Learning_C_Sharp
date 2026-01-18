using System;
using System.Collections.Generic;
using System.IO;

namespace ExpenseTracker
{
    class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} | {Category} | {Description} | Rs.{Amount}";
        }
    }

    class ExpenseManager
    {
        private List<Expense> expenses = new List<Expense>();
        private string filePath = "expenses.txt";

        public void AddExpense(Expense exp)
        {
            expenses.Add(exp);
            SaveToFile();
        }

        public void ViewExpenses()
        {
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded yet.");
                return;
            }

            Console.WriteLine("\n--- All Expenses ---");
            foreach (var exp in expenses)
                Console.WriteLine(exp);
        }

        public void TotalExpenses()
        {
            decimal total = 0;
            foreach (var exp in expenses)
                total += exp.Amount;
            Console.WriteLine($"\nTotal Expenses: Rs.{total}");
        }

        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var exp in expenses)
                {
                    sw.WriteLine($"{exp.Date},{exp.Category},{exp.Description},{exp.Amount}");
                }
            }
        }

        public void LoadFromFile()
        {
            if (!File.Exists(filePath)) return;

            expenses.Clear();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                expenses.Add(new Expense
                {
                    Date = DateTime.Parse(parts[0]),
                    Category = parts[1],
                    Description = parts[2],
                    Amount = decimal.Parse(parts[3])
                });
            }
        }
    }

    class Expensive_mini_project
    {
        static void Main()
        {
            ExpenseManager manager = new ExpenseManager();
            manager.LoadFromFile();

            while (true)
            {
                Console.WriteLine("\n--- Expense Tracker ---");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Total Expenses");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Date (yyyy-mm-dd): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Category: ");
                        string category = Console.ReadLine();
                        Console.Write("Enter Description: ");
                        string desc = Console.ReadLine();
                        Console.Write("Enter Amount: ");
                        decimal amount = decimal.Parse(Console.ReadLine());

                        manager.AddExpense(new Expense
                        {
                            Date = date,
                            Category = category,
                            Description = desc,
                            Amount = amount
                        });
                        Console.WriteLine("Expense added successfully!");
                        break;

                    case "2":
                        manager.ViewExpenses();
                        break;

                    case "3":
                        manager.TotalExpenses();
                        break;

                    case "4":
                        Console.WriteLine("Exiting... Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
