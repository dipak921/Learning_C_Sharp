using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    internal class Hotel_Mangment_System
    {
        static void Main(string[] args)
        {

            // Variables and data Types
            int roomNumber = 101;
            double roomPrice = 1350.20;
            string guestName = "";
            int[] roomBooked = { };
            int[] roomNumbers = { 101, 102, 103, 104, 105 };
            double[] roomPrices = { 150.75, 180.50, 200.00, 250.00, 300.00 };

            bool isValidChoice = true;
            do
            {
                // Basic input
                Console.WriteLine("*****Hotel Mangment System*****");
                Console.WriteLine("1. Book Room");
                Console.WriteLine("2. View room Availability");
                Console.WriteLine("3. Check Out");
                Console.WriteLine("4. Exit");
                Console.Write("Please Choose an option (1-4): ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Method for booking a room");
                        break;
                    case "2":
                        Console.WriteLine("Method to view room availability");
                        break;
                    case "3":
                        Console.WriteLine("Method for check out");
                        break;
                    case "4":
                        isValidChoice = false;
                        Console.WriteLine("Exit Application");
                        break;
                    default:
                        Console.WriteLine(" Input Error, Try again");
                        break;
                }
            } while (isValidChoice);



            Console.ReadLine();
        }
    }
}

