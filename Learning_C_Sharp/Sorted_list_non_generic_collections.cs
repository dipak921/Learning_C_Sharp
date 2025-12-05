using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Learning_C_Sharp
{
    internal class Sorted_list_non_generic_collections
    {
        static void DisplayList(SortedList sl)
        {
            foreach(DictionaryEntry item in sl)
            {
                Console.WriteLine($"ID :{item.Key}, Name is :{item.Value}");
            }
        }
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(3, "Dipak");
            sl.Add(5, "Amol");
            sl.Add(6, "Deepak");
            sl.Add(4, "Vishal");
            sl.Add(1, "Annasaheb");
            sl.Add(2, "Mahesh");
            Console.WriteLine("======== Sorted List ==========");
            DisplayList(sl);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Value of key 3: "+ sl[3]);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Value at index : "+ sl.GetByIndex(3));
            sl[2] = "Yogesh";
            Console.WriteLine("======== Updated List ==========");
            DisplayList(sl);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("======== Remove Value ==========");
            sl.Remove(3);
            DisplayList(sl);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("======== Contains key ==========");
            if (sl.ContainsKey(5))
            {
                Console.WriteLine("Name is Exists");
            }
            else
            {
                Console.WriteLine("Name is not  Exist");
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine("======== Contains Value ==========");
            if (sl.ContainsValue("Yogesh"))
            {
                Console.WriteLine("Name is Exists");
            }
            else
            {
                Console.WriteLine("Name is not Exist");
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine("======== Clear Value ==========");
            sl.Clear();
            Console.WriteLine("the Count is after clear :" + sl.Count);
            Console.WriteLine("----------------------------------");



            Console.ReadLine();
        }
    }
}
