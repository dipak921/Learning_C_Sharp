using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Shoping
    {
        public string name;
        public string proudctName;
        public double proudctPrice;
        private double tax = 0.08;
        public int handlingCharges = 25;
        double payAbleAmount;

        public Shoping(string name, string proudctName, double proudctPrice) 
        { 
            this.name = name;
            this.proudctName = proudctName;
            this.proudctPrice = proudctPrice;
        }
        private void CalculateAmount()
        {
            double taxAmount = proudctPrice * tax;
            payAbleAmount = proudctPrice + taxAmount + handlingCharges;
            Console.WriteLine($"Tax * 8% : {taxAmount}");
            Console.WriteLine($"Processing fee : {handlingCharges}");
            Console.WriteLine($"payAble Amount fee : {payAbleAmount}");
        }
        public void showEmployeeDetails()
        {
            Console.WriteLine($"Cust Name :{name}");
            Console.WriteLine($"Product Name : {proudctName}");
            Console.WriteLine($"Product Price :{proudctPrice}");


            this.CalculateAmount();
        }
    }
    internal class shopping_ex_with_abstraction
    {
        static void Main(string[] args)
        {
            Shoping s = new Shoping("dipak","T-shirt", 450);
            s.showEmployeeDetails();

            Console.WriteLine("-------------------------------------------------------------");

            Shoping s1 = new Shoping("Ramesh", "Black-hodi", 750);
            s1.showEmployeeDetails();
        }
    }
}
