using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class shoping
    {
        public int item;
        public int price;
        private int total=0;

        public void items()
        {
            if (item < 0)
            {
                Console.WriteLine("enterr valid item");
            }
            else
            {
                Console.WriteLine("Enter a How many item add");
                item = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void pices()
        {
            if (price < 0)
            {
                Console.WriteLine("enter valid amount");
            }
            else
            {
                Console.WriteLine("Enter Price");
                price = Convert.ToInt32(Console.ReadLine());
                this.price = price;
            }
        }

        public void totalbill()
        {
            total = price * item;
            Console.WriteLine("Your total bill is :" + total);
        }
    }

    internal class Encapsulation_ex4
    {
        static void Main(string[] args)
        {
            shoping s=new shoping();
            s.items();
            s.pices();
            s.totalbill();







            Console.ReadLine();
        }
    }
}
