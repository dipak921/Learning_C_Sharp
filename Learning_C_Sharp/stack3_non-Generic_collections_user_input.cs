using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class stack3_non_Generic_collections_user_input
    {
        static void Main(string[] args)
        {
            Stack mystack2 = new Stack();
            int choice;
            do
            {
                Console.WriteLine("======Stack Menu========");
                Console.WriteLine("1. Push Element");
                Console.WriteLine("2. Pop Element");
                Console.WriteLine("3. Peek Element");
                Console.WriteLine("4. Display Element");
                Console.WriteLine("5. Check Element (Contains) ");
                Console.WriteLine("6. Total Element ");
                Console.WriteLine("7. Clear Stack Element ");
                Console.WriteLine("8. Exit");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input, Please a Number (1-8)");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Elemetn to Push :");
                        string input = Console.ReadLine();
                        mystack2.Push(input);
                        break;

                    case 2:
                        if (mystack2.Count > 0)
                        {
                            var poped = mystack2.Pop();
                            Console.WriteLine($"Poped Elemetn :{poped}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        break;

                    case 3:
                        if (mystack2.Count > 0)
                        {
                            var top = mystack2.Pop();
                            Console.WriteLine($"Top Elemetn :{top}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        break;

                    case 4:
                        if (mystack2.Count > 0)
                        {
                            Console.WriteLine($"Top Elemetn ");
                            foreach (var item in mystack2)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stack is Empty");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter check elements");
                        string check = Console.ReadLine();
                        bool exists = mystack2.Contains(check);
                        Console.WriteLine(exists ? "Elment fount" : "Element Not Found");
                        break;

                    case 6:
                        Console.WriteLine("Total Elments Coutn is :", mystack2.Count);
                        break;

                    case 7:
                        mystack2.Clear();
                        Console.WriteLine("Stack Cleared");
                        break;

                    case 8:
                        Console.WriteLine("Exiting..........");
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
            } while (choice != 8);



            Console.ReadLine();
        }
    }
}
