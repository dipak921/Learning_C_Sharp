using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class bankAccount
    {
        private string accountHolder;
        private string accountNo;
        private double blance;

        //Account creation
        public void CreateAccount()
        {
            Console.WriteLine("Enter account holder name");
            accountHolder = Console.ReadLine();
            Console.WriteLine("Enter account Number");
            accountNo = Console.ReadLine(); 
            Console.WriteLine("Enter operning blance :");
            blance = Convert.ToDouble(Console.ReadLine());
        }

        public void Deposite()
        {
            Console.WriteLine("Enter Deposite Amount :");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 0)
            {
                blance += amount;
                Console.WriteLine("amount deposited sucssefully");
            }
            else
            {
                Console.WriteLine("Invalid Deposite amount");
            }
        }
        public void withdraw()
        {
            Console.WriteLine("Enter Withdraw amount ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount > 0 && amount <= blance)
            {
                blance -= amount;
                Console.WriteLine("amount withdraw successfully");
            }
            else
            {
                Console.WriteLine("Insuffisient Blance or Invalid amount");
            }
        }

        public void showAccountInfo()
        {
            Console.WriteLine("----------Account Summary------------");
            Console.WriteLine("Accoutn Holder Name :" + accountHolder);
            Console.WriteLine("Accoutn Holder Number is :" + accountNo);
            Console.WriteLine("Your Current Blance :" + blance);
        }
    }
    internal class Encapsulation_ex2_banking
    {
        static void Main(string[] args)
        {
            bankAccount acc = new bankAccount();
            acc.CreateAccount();
            acc.Deposite();
            acc.withdraw();
            acc.showAccountInfo();
            




            Console.ReadLine();
        }
    }
}
