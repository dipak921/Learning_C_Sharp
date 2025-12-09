using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Generic_Hash_Set
    {
        static void display(HashSet<string> fruitset)
        {
            foreach(string fruit in fruitset)
            {
                Console.WriteLine(fruit);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("----Create HashSet and add value----------");
            HashSet<string> fruitset = new HashSet<string>();
            fruitset.Add("Apple");
            fruitset.Add("Mango");
            fruitset.Add("Banana");
            fruitset.Add("Orange");
            //fruitset.Add("Mango");
            //bool added = fruitset.Add("Mango");
            //Console.WriteLine("Tried to add 'Manono' " + (added ? "Added" : "Already Exit"));
            display(fruitset);

            //Console.WriteLine("***********Contains*******************");
            //Console.WriteLine("contains 'Banan': "+ fruitset.Contains("Banana"));
            //Console.WriteLine("------------------------------------------------------");
            //HashSet<string>  newfruit = new HashSet<string>()
            //{
            //    "Mango","Apple","Papaya"
            //};
            //fruitset.UnionWith(newfruit);
            //Console.WriteLine("After Union");
            //foreach (string fruit in fruitset)
            //{
            //    Console.WriteLine(fruit);
            //}
            //Console.WriteLine("------------------------------------------------------");

            //HashSet<string> seasonfruit = new HashSet<string>()
            //{
            //    "Pineaplle","Apple","Banana","Cheery"
            //};

            //Console.WriteLine("----------------After IntersectWith------------------");
            //fruitset.IntersectWith(seasonfruit);
            //foreach (string fruit in fruitset)
            //{
            //    Console.WriteLine(fruit);
            //}
            Console.WriteLine("--------------ExceptWith------------------ ");

            HashSet<string> toRemove = new HashSet<string>()
            {
                "Apple"
            };
            fruitset.ExceptWith(toRemove);

            foreach (string fruit in fruitset)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("--------------Sorted List------------------ ");








            Console.ReadLine();
        }
    }
}
