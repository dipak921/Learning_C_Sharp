using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class BankAccount_CO
    {
        class BankAccount1
        {
            public int accountNumber;
            public string accountHolderName;
            public double balance;
        
            public void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine("Deposited "+amount);
            }
            public void Withdrawn(double amount)
            {
                if(amount <= balance)
                {
                    balance = balance - amount;
                    Console.WriteLine("Withdrewn" + amount);
                }
                else
                {
                    Console.WriteLine("Insffiecient Balance");
                }
            }

            public void Display()
            {
                Console.WriteLine("Account Number :" +accountNumber);
                Console.WriteLine("Accoutn Holder Name :" + accountHolderName);
                Console.WriteLine("Balance:" + balance);
            }
        }
        static void Main(string[] args)
        {
            BankAccount1 acc1 = new BankAccount1();
            acc1.accountNumber = 93782;
            acc1.accountHolderName = "Ram";
            acc1.balance = 1000;

            acc1.Deposit(2000);
            acc1.Withdrawn(300);
            acc1.Display();

            Console.WriteLine("--------------------------------------------");
            BankAccount1 acc2 = new BankAccount1();
            acc2.accountNumber = 7895;
            acc2.accountHolderName = "Jayant";
            acc2.balance = 6300;

            acc2.Deposit(700);
            acc2.Withdrawn(1000);
            acc2.Display();

            Console.WriteLine("--------------------------------------------");
            BankAccount1 acc3 = new BankAccount1();
            acc3.accountNumber = 4563;
            acc3.accountHolderName = "Dipak";
            acc3.balance = 4500;

            acc3.Deposit(700);
            acc3.Withdrawn(100);
            acc3.Display();

            Console.ReadLine();
        }
    }
}
