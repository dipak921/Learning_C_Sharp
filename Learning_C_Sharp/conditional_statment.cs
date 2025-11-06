using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class conditional_statment
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a Age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18)
            //{
            //    Console.WriteLine("Eligiable for Vote");
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligiable for Vote");
            //}

            //Console.WriteLine("Enter a Name");
            //string name = Console.ReadLine();

            //if (name == "Dipak")
            //{
            //    Console.WriteLine("Welcom Dipak");
            //}
            //else
            //{
            //    Console.WriteLine("Who are you.?");
            //}

            //Console.WriteLine("Enter a username");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter a Password");
            //string Password = Console.ReadLine();

            //if (name == "Annad" && Password == "1234")
            //{
            //    Console.WriteLine("Login sucessfully");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Information");
            //}


            //Console.WriteLine("Enter a Percentage");
            //int percetage = Convert.ToInt32(Console.ReadLine());

            //if (percetage >= 80)
            //{
            //    Console.WriteLine("Distinction");
            //}
            //else if(percetage >= 70)
            //{
            //    Console.WriteLine("First Class");
            //}
            //else if (percetage >= 50)
            //{
            //    Console.WriteLine("Second Class");
            //}
            //else if (percetage >= 35)
            //{
            //    Console.WriteLine("Pass Class");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //Console.WriteLine("Enter the Temperature");
            //int temperature = Convert.ToInt32(Console.ReadLine());

            //if (temperature >= 40)
            //{
            //    Console.WriteLine("Very Hot");
            //}
            //else if (temperature >= 30)
            //{
            //    Console.WriteLine("Hot");
            //}
            //else if (temperature >= 10)
            //{
            //    Console.WriteLine("Cool");
            //}
            //else
            //{
            //    Console.WriteLine("Cold");
            //}

            //Console.WriteLine("Enter the UserName(email_id)");
            //string username = Console.ReadLine();

            //if(username == "dipakchande921@gmail.com") {
            //    Console.WriteLine("Enter the Password");
            //    string password = Console.ReadLine();
            //    if(password == "dipak")
            //    {
            //        Console.WriteLine("Login Sucessfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Password");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong UserName");
            //}

            //int x = 3;
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Sundy");
            //    break;
            //     case 2:
            //        Console.WriteLine("Mon");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wensday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Not day");
            //        break;
            //}

            //Console.WriteLine("Enter your pizza:");
            //string pizza = Console.ReadLine();


            //switch (pizza)
            //{
            //    case "Corn":
            //        Console.WriteLine("Your order is corn pizza");
            //        break;

            //    case "Supreme":
            //        Console.WriteLine("Your order is supreme pizza");
            //        break;

            //    case "Vegetable":
            //        Console.WriteLine("Select Your Vegetable Choice");
            //        string Vegetable = Console.ReadLine();

            //        switch (Vegetable)
            //        {
            //            case "onion":
            //                Console.WriteLine("You selected onion pizza");
            //                break;
            //            case "capcicum":
            //                Console.WriteLine("You selected capcicum pizza");
            //                break;
            //            case "olives":
            //                Console.WriteLine("You selected olives pizza");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid Choice");
            //                break;
            //        }
            //        break;

            //}


            Console.WriteLine("Enter a Price");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Customer Type(Premium or Regular)");
            string type = Console.ReadLine();

            Console.WriteLine("Enter a PaymentMethod");
            string payamentMethod = Console.ReadLine();

            int discount = 0;


            if (type == "premium")
            {
                if (price >= 10000 && payamentMethod == "card")
                {
                    Console.WriteLine("I am providing a 20% discount");
                    discount = price + price /100 * 20;
                }
                else if (price >= 10000 && payamentMethod == "cash")
                {
                    Console.WriteLine("I am providing a 15% discount");
                    discount = price + price / 100 * 15;
                }
                else if (price <= 10000 && payamentMethod == "any")
                {
                    Console.WriteLine("I am providing a 10% discount");
                    discount = price + price / 100 * 10;
                }
                else
                {
                    Console.WriteLine("Not eligible for discount");
                }
            }
            else if (type == "regular")
            {
                if (price >= 5000 && payamentMethod == "card")
                {
                    Console.WriteLine("I am providing a 5% discount");
                    discount = price + price / 100 * 5;
                }
                if (price >= 5000 && payamentMethod == "cash")
                {
                    Console.WriteLine("I am providing a 3% discount");
                    discount = price + price / 100 * 3;
                }
                else
                {
                    Console.WriteLine("Not eligible for discount");
                }
            }


            Console.WriteLine(discount);

            Console.ReadLine();

        }
    }
}


