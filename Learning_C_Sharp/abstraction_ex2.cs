using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    abstract class Pyametn
    {
        public double amount;
        public string CustomerName;

        public void ShowBasicInfo()// Non- Abstract Method
        {
            Console.WriteLine($"Customer Name :{CustomerName}, Amount : {amount}");
        }
        public abstract void ProcessPayment(); //Abstract Method
    }
    class CreditCardPaymetn : Pyametn
    {
        public string cardNumber;
        public override void ProcessPayment()
        {
            Console.WriteLine("Processign credit card payment using {0}", cardNumber);
            Console.WriteLine("CreditCard paymetn successfully");
        }
    }
    class upiPaymetn : Pyametn
    {
        public string upiid;
        public override void ProcessPayment()
        {
            Console.WriteLine("Processign UPI  payment using {0}", upiid);
            Console.WriteLine("UPI paymetn successfully");
        }
    }

    class NetBankingPyament : Pyametn
    {
        public string Bank_Name;
        public override void ProcessPayment()
        {
            Console.WriteLine("Processign NetBankin  payment using {0}", Bank_Name);
            Console.WriteLine("Net Banking paymetn successfully");
        }
        internal class abstraction_ex2
        {
            static void Main(string[] args)
            {
                Console.WriteLine("-------------------Credit Card-----------------------------------");

                Pyametn p = new CreditCardPaymetn
                {
                    CustomerName = "Jayant",
                    amount = 15000,
                    cardNumber = "123-456-789"
                };
                p.ShowBasicInfo();
                p.ProcessPayment();

                Console.WriteLine("-------------------UPI-----------------------------------");
                Pyametn p1 = new upiPaymetn
                {
                    CustomerName = "Ram",
                    amount = 160820,
                    upiid = "dipak@unbil"

                };
                p1.ShowBasicInfo();
                p1.ProcessPayment();
                Console.WriteLine("-------------------Net Banking-----------------------------------");
                Pyametn p2 = new NetBankingPyament
                {
                    CustomerName = "Ram",
                    amount = 16900,
                    Bank_Name = "Union Bank of India"

                };
                p2.ShowBasicInfo();
                p2.ProcessPayment();
               

                Console.ReadLine();
            }
        }
    }
}
