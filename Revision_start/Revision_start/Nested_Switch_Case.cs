using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- The Nested Switch Case Statement
    - C# allows the switch.. case construct to be nested. That is, a case block of a switch case construct can contain another switch cast construct.
    - Also, the case constants of the inner switch case construct can have the same values as the case constants of the outer switch case construct.
     */
    internal class Nested_Switch_Case
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Pizza flavour : ");
            string pizza_flavour = Console.ReadLine();

            switch(pizza_flavour)
            {
               case "Veggie":
                    Console.WriteLine("Enter the size of the pizza : ");
                    string veggie_pizza_size = Console.ReadLine();
                    switch(veggie_pizza_size)
                    {
                        case "Small":
                            Console.WriteLine("You have ordered a small Veggie Pizza");
                            break;
                        case "Medium":
                            Console.WriteLine("You have ordered a medium Veggie Pizza");
                            break;
                        case "Large":
                            Console.WriteLine("You have ordered a large Veggie Pizza");
                            break;
                        default:
                            Console.WriteLine("Invalid Size");
                            break;
                    }
                    break;
                case "Pepperoni":
                    Console.WriteLine("Enter the size of the pizza : ");
                    string pepperoni_pizza_size = Console.ReadLine();
                    switch (pepperoni_pizza_size)
                    {
                        case "Small":
                            Console.WriteLine("You have ordered a small Pepperoni Pizza");
                            break;
                        case "Medium":
                            Console.WriteLine("You have ordered a medium Pepperoni Pizza");
                            break;
                        case "Large":
                            Console.WriteLine("You have ordered a large Pepperoni Pizza");
                            break;
                        default:
                            Console.WriteLine("Invalid Size");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Pizza Flavour");
                    break;
            }



            Console.ReadLine();
        }
    }
}
