using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    interface Ipayment
    {
        void Pay(string from, string to, double amount);
        void sendReceipt(string to,double amount);
        void LogPayment(string method, string status, DateTime time);
    }
    class CreaditCard : Ipayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"{from} to {to} send Money {amount}");
        }
        public void sendReceipt(string to, double amount)
        {
            Console.WriteLine($"sending recipt {to} of amount {amount}");
        }
        public void LogPayment( string method, string status, DateTime time)
        {
            Console.WriteLine($"Log{method} stustus is {status} at {time}");
        }
    }
    class upi : Ipayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"UPI id{from} to  this upi id{to} send Money in  {amount}");
        }
        public void sendReceipt(string to, double amount)
        {
            Console.WriteLine($"sending recipt {to} of amount {amount}");
        }
        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"Upi{method} stustus is {status} at {time}");
        }
    }
    class cash  : Ipayment
    {
        public void Pay(string from, string to, double amount)
        {
            Console.WriteLine($"cash {from} to {to} in  {amount}");
        }
        public void sendReceipt(string to, double amount)
        {
            Console.WriteLine($"cash recipt {to} of amount {amount}");
        }
        public void LogPayment(string method, string status, DateTime time)
        {
            Console.WriteLine($"= Payment via  {method} stustus is {status} at {time}");
        }
    }
    internal class interface_ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Credit card-----------------------");
            Ipayment ipayment = new CreaditCard();
            ipayment.Pay("dipak","om",45000);
            ipayment.sendReceipt("om", 45000);
            ipayment.LogPayment("Credit Card", "processing", DateTime.Now);
            Console.WriteLine("----------UPI card-----------------------");
            Ipayment upi = new upi();
            upi.Pay(" ramesh", " rani", 20000);
            upi.sendReceipt("rami", 20000);
            upi.LogPayment("Upi Id", "Failed", DateTime.Now);
            Console.WriteLine("----------Cash card-----------------------");
            Ipayment cash = new cash();
            cash.Pay("akash", "kalpesh", 85200);
            cash.sendReceipt("kalpesh", 85200);
            cash.LogPayment("Cash", "sucess", DateTime.Now);




            Console.ReadLine();
        }
    }
}
