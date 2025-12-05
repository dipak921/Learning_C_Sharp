using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Generic_list_1
    {
       static void PrintCity(List<string> citylist)
        {
            foreach(string item in citylist)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("======Add==========");

            List<string> citylist = new List<string>();
            citylist.Add("Pune");
            citylist.Add("Mumbai");
            citylist.Add("Latur");

            PrintCity(citylist);
            Console.WriteLine("-----------------------");
            Console.WriteLine("=====Add Range=========");

            citylist.AddRange(new List<string> {"Satara","Delhi","Ahilyanagar","Newasa"});
            PrintCity(citylist);

            Console.WriteLine("-----------------------");
            Console.WriteLine("=====Insert Range=========");
            citylist.Insert(1, "Karad");
            PrintCity(citylist);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Insert a Range=========");
            citylist.InsertRange(2,new List<string> { "Kolhapur", "Nagapu", "Nashik" });
            PrintCity(citylist);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Remove At=========");
            citylist.RemoveAt(2);
            PrintCity(citylist);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Remove Range index to index=========");
            citylist.RemoveRange(2,4); // Remove form 2 to next 4 item
            PrintCity(citylist);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Remove All =========");
            citylist.RemoveAll(c => c.StartsWith("N"));
            PrintCity(citylist);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Contains =========");
            Console.WriteLine("Contains Karad ?" + citylist.Contains("Karad"));
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Find index =========");
            Console.WriteLine("Index of Karad ?" + citylist.IndexOf("Karad"));
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Sort Item =========");
            citylist.Sort();
            PrintCity(citylist);
            Console.WriteLine("=====Reverse Item =========");
            citylist.Reverse();
            PrintCity(citylist);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Count Item =========");
            Console.WriteLine("The Count of city :"+ citylist.Count);
            Console.WriteLine("-----------------------");

            Console.WriteLine("=====Clear Item =========");
            citylist.Clear();
            Console.WriteLine("The Count of city :" + citylist.Count);
            Console.WriteLine("-----------------------");





            Console.ReadLine();
        }
    }
}
