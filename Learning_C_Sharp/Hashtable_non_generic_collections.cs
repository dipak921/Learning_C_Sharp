using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  What is a Hashtable (Non-Generic)?
- Namespace: System.Collections
- Definition: A non-generic collection that stores key–value pairs.
- Key uniqueness: Each key must be unique.
- Value flexibility: Values can be of any type (since it’s non-generic, stored as object).
- Hashing principle: Internally, it uses a hash code of the key to quickly locate 
- यात key–value pairs ठेवले जातात.
- Key unique असतो, value काहीही असू शकतो (string, int, bool).


- Properties:
- Count → किती pairs आहेत
- Keys → सगळे keys मिळतात
- Values → सगळे values मिळतात
- ContainsKey → दिलेला key आहे का?
- ContainsValue → दिलेला value आहे का?
- Item[key] → key ने value मिळ


 
 */
namespace Learning_C_Sharp
{
    internal class Hashtable_non_generic_collections
    {
        static void diplayProduct(Hashtable ht)
        {
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine($"ID: {item.Key}, Product Name :{item.Value}");
            }
        }
        static void Main(string[] args)
        {
            Hashtable product = new Hashtable();
            product.Add(101, "Laptop");
            product.Add(102, "Mobile");
            product.Add(103, "Tablet");
            product.Add(104, "PC");
            Console.WriteLine("Initial Product List");
            diplayProduct(product);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"\n Total Product :{product.Count}");

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"\n Product with ID 102 - {product[102]}");

            Console.WriteLine("---------------------------------------------------------------");
            product[102] = "SmartPhone";
            Console.WriteLine("Updated Produt with id 102 " + product[102]);
            Console.WriteLine("---------------------------------------------------------------");
            diplayProduct(product);

            Console.WriteLine("---------------------------------------------------------------");
            product[104] = "Gamming Laptop";
            Console.WriteLine("Updated Produt with id 102 " + product[104]);
            Console.WriteLine("---------------------------------------------------------------");
            diplayProduct(product);

            Console.WriteLine("-----------------------------Form Key---------------------------");
            if(product.ContainsKey(105))
            {
                Console.WriteLine("Product is Exists");
            }
            else
            {
                Console.WriteLine("Product is not Exists");
            }
            Console.WriteLine("-------------------------------From Value------------------------");
            if(product.ContainsValue("SmartPhone"))
            {
                Console.WriteLine("Product name exists");
            }
            else
            {
                Console.WriteLine("Product name does not exists");
            }
            Console.WriteLine("-------------------------------Remove ----------------------------");
            product.Remove(101);
            diplayProduct(product);
            Console.WriteLine("-------------------------------Clear ------------------------------");
            product.Clear();
            Console.WriteLine($"\n Total Product :{product.Count}");
            Console.WriteLine("--------------------------------------------------------------------");



            Console.ReadLine();
        }
    }
}
