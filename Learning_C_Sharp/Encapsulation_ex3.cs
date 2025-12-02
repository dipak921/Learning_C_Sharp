using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Hotel
    {
        private string gustName;
        private int roomNo;
        private int stay;
        private double rentPerDay = 1300;
        private double totalbill;

        public void BookingDetail()
        {
            Console.WriteLine("Enter Your Name for Booking :");
            gustName = Console.ReadLine();
            Console.WriteLine("Enter favourite Room Number(1-150) for Booking : ");
            roomNo = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculteBill()
        {
            Console.WriteLine("Enter How Many day stay here :");
            stay = Convert.ToInt32(Console.ReadLine());
            if(stay > 0)
            {
                totalbill = stay * rentPerDay; 
            }
            else
            {
                Console.WriteLine("You decide how long you will stay in the hotel.");
            }
        }
        public void showDetail()
        {
            Console.WriteLine("Your Name is :" + gustName);
            Console.WriteLine("Your Room No is :" + roomNo);
            Console.WriteLine($"Your Stay is in {stay} days");
            Console.WriteLine("Per day Rent is "+ rentPerDay);
            Console.WriteLine("Total bill is "+ totalbill);
        }
    }
    internal class Encapsulation_ex3
    {
        static void Main(string[] args)
        {
            Hotel h = new Hotel();
            h.BookingDetail();
            h.CalculteBill();
            Console.WriteLine("-------------Booking confirm-------------------");
            h.showDetail();

            Console.ReadLine();
        }
    }
}
