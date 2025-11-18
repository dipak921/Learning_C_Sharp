using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Home_work_ex
    {
        public void Greating()
        {
            Console.Write("Enter Customer Name :");
            string custName = Console.ReadLine();
            Console.WriteLine($"Welcome ,{custName}");
            Console.WriteLine("----------Dipak’s Urban Mall ----------");
        }
        public  void Item(string itemName, int price)
        {
            Console.WriteLine($"Selected item :{itemName} Price : {price} per unit");
        }

        public  int totalAmount()
            {
            Console.Write("Entre a Price per unit :");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Entre a Quntity :");
            int qnt = int.Parse(Console.ReadLine());
            double total = price * qnt;
            Console.WriteLine($"Total (without discount): {total}");
            return(int) total;
            }

        public double FinalPay(double discountPercent, double totalAmount)
        {
            double discountAmount = (discountPercent / 100) * totalAmount;
            double finalAmount = totalAmount - discountAmount;
            return finalAmount;
        }


        static void Main(string[] args)
        {
            //1
            Home_work_ex great = new Home_work_ex();
            great.Greating();

            //2
            Console.Write("Enter Item name :");
            string itemName = Console.ReadLine();

            Console.Write("Enter price : ");
            int price = int.Parse( Console.ReadLine());
            great.Item(itemName, price);
            //3
            great.totalAmount();
            //4
           
            Console.Write("Enter discount percent: ");
            double discount = double.Parse(Console.ReadLine());
            Console.Write("Enter total amount : ");
            double totalAmount = double.Parse(Console.ReadLine());



            double finalPrice = great.FinalPay(discount, totalAmount);
            Console.WriteLine($"Final Amount after discount: {finalPrice}");




            Console.Write("thank you for shopping");



            Console.ReadLine();
        }
    }
}
