using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Dictionary in C# is a generic collection that stores key-value pairs. The working of Dictionary is quite similar to the non-generic hashtable.
The advantage of a Dictionary is, that it is a generic type. A dictionary is defined under System.Collections.Generic namespace.
It is dynamic in nature means the size of the dictionary is growing according to the need.

Key-Value Pair: The value is stored in the Key-Value pair.
Efficient Lookup: It provides fast lookups for values based on keys.
Unique Keys: Stored keys uniquely and adding duplicate keys results in a runtime exception.

- Dictionary<TKey, TValue>: key-value जोड्यांचा संग्रह; key ने lookup अतिशय जलद.
- Key unique: एकाच key चे दोन entries होत नाहीत.
- Safe lookup: TryGetValue वापरा; missing key वर exception टाळा.
- Comparer: StringComparer.OrdinalIgnoreCase दिल्यास case-insensitive keys मिळतात.
- Order: हमखास नाही; क्रम हवे असेल तर SortedDictionary किंवा वेगळ्या List मध्ये order जपा.
If you want, I’ll craft a compact “only one if” upsert demo and a frequency counter with neat formatting, aligned to your minimal-logic style.

 */
namespace Learning_C_Sharp
{
    internal class Generic_DictionaryList_ex
    {
        static void displayStudent(Dictionary<int, string> students)
        {
            foreach(var student in students)
            {
                Console.WriteLine($"Studen id is : {student.Key} and name is : {student.Value}");
            }
        }
        static void Main(string[] args)
        {
            //Dictionary<int,string> student = new Dictionary<int,string>();
            //Console.WriteLine("====== Student List =======");
            ////student.Add(1, "dipak");
            ////student.Add(2, "amol");
            ////student.Add(3, "vishal");
            ////student.Add(4, "jayant");
            ////student.Add(5, "kalpesh");
            ////student.Add(6, "om");
           
            //********************Second methdo to value provide************************

            Dictionary<int,string> student = new Dictionary<int,string>()
            {
                {101,"Om"},
                {102,"Vishal"},
                {103,"Lakhan"},
                {104,"Dipak"}
            };

            displayStudent(student);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("====== Contains value and key =======");
            Console.WriteLine("The contains Vishal : "+ student.ContainsValue("vishal"));
            Console.WriteLine("The contains key 6 : "+ student.ContainsKey(6));
            Console.WriteLine("====== Update value =======");
            student[1] = "ram";
            student.Remove(5);
            displayStudent(student);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("====== Only key =======");
            foreach (var key in student.Keys)
            {
                Console.WriteLine("Studen Key is " + key);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("====== Only valu =======");
            foreach (var value in student.Values)
            {
                Console.WriteLine("Studen Name is " + value);
            }
            Console.WriteLine("-----------------------------");


            Console.ReadLine();
        }
    }
}
