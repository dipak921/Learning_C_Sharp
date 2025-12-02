using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Learning_C_Sharp
{
    class student12
    {
        public string Name;
        public int Age;
    }
    internal class Non_Gerneric_array_list
    {
        static void Example1_storing_differnt_data_type()
        {
            ArrayList list = new ArrayList();
            list.Add(12);
            list.Add("Dipak");
            list.Add(3.54);
            list.Add(true);

            Console.WriteLine("Example 1 : Storing Diffrent Data Type");
            foreach(object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        static void Example2_Rmove_Insert_Item()
        {
            ArrayList fruitlist = new ArrayList();
            fruitlist.Add("Apple");
            fruitlist.Add("Apple");
            fruitlist.Add("Banana");
            fruitlist.Add("Grapes");
            fruitlist.Add("PipeApple");

            // Remove from indexing number
            fruitlist.RemoveAt(0);

            // Remove from particular value
            fruitlist.Remove("Grapes");
            fruitlist.Remove("PipeApple");

            // Inserting a value in index value
            fruitlist.Insert(1, "Orange");
            fruitlist.Insert(2, "Chiku");
            fruitlist.Insert(3, "Peru");

            Console.WriteLine("Example 2 : Remove and Insert");
            foreach (object fruit in fruitlist)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("---------------------------------------------------------------------------------");

        }

        static void Example3_Sorting_Vlaue()
        {
            ArrayList number = new ArrayList() { 45, 89, 74, 85, 6, 2, 78, 24, 63 };
            Console.WriteLine("Example 3 : Sorting Item");
            number.Sort();
            Console.WriteLine("Sort Array");
            foreach (object num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Reverse Array");
            number.Reverse();

            foreach (object num in number)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        static void Example4_Seacrch_Vlaue()
        {
            ArrayList names = new ArrayList() { "Dipak","Rma","Rakesh","Annasaheb","Yogesh"};

            Console.WriteLine("Example 4 : Seacrch Element");
            if(names.Contains("Annasaheb"))
            {
                Console.WriteLine("This Name is in our list");
            }
            else
            {
                Console.WriteLine("Names is not found !");
            }

                Console.WriteLine("---------------------------------------------------------------------------------");
        }

        static void Example5_copyToarray()
        {
            ArrayList cities = new ArrayList()  {"Mumbai", "Pune", "Hydrabad" };

            string[] cityArray = new string[cities.Count];
            cities.CopyTo(cityArray);

            Console.WriteLine("Example 5 :Copy Array ");
            foreach(string city in cityArray)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        static void Exmple5_using_object()
        {
            ArrayList student12 = new ArrayList();
            student12.Add(new student12 { Name = "Dipak", Age = 59 });
            student12.Add(new student12 { Name = "Rakesh", Age = 53 });
            foreach(student12 s in student12)
            {
                Console.WriteLine($"{s.Name} - {s.Age}");
            }
        }
        static void Main(string[] args)
        {
            Example1_storing_differnt_data_type();

            Example2_Rmove_Insert_Item();

            Example3_Sorting_Vlaue();

            Example4_Seacrch_Vlaue();

            Example5_copyToarray();

            Exmple5_using_object();



            Console.ReadLine();
        }
    }
}
