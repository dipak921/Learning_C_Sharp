using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Payment_fucntion_overloading
    {
        public void Pay(int amount)
        {
            Console.WriteLine($" Your Payment is accepted on Cash of amount: {amount} .");
        }
        public void Pay(int amount, string cardType)
        {
            Console.WriteLine($"Your Payment is accepted amount :{amount} on this card {cardType} card .");
        }
        public void Pay(int amount, string upi, bool isUpi)
        {
            if (isUpi)
                Console.WriteLine($" Your UPI amount is :{amount} on this Upi Id : {upi}");
            else
                Console.WriteLine("invalid UPI.");
        }

        static void Main(string[] args)
        {
            Payment_fucntion_overloading payment = new Payment_fucntion_overloading();

  
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Card");
            Console.WriteLine("3. UPI");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    payment.Pay(amount); 
                    break;

                case 2:
                    Console.Write("Enter Card Type (VISA/MASTER): ");
                    string cardType = Console.ReadLine();
                    payment.Pay(amount, cardType); 
                    break;
                case 3:
                    Console.Write("Enter UPI App Id: ");
                    string upiApp = Console.ReadLine();
                    payment.Pay(amount, upiApp, true); 
                    break;

                default:
                    Console.WriteLine("Invalid.");
                    break;
            }


            Console.ReadLine();
        }
    }
}
