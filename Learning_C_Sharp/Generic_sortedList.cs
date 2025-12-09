using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Generic_sortedList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> student = new SortedList<int, string>();
            student.Add(102, "Dipak");
            student.Add(104, "Sagar");
            student.Add(103, "Vishal");
            student.Add(108, "Om");
            Console.WriteLine("student List");
            foreach (var pair  in student)
            {
                Console.WriteLine($"student roll No :{pair.Key} and Name is :{pair.Value}");
            }
            Console.WriteLine("Contains Value*********************");
            Console.WriteLine("Contains Key 108: " + student.ContainsKey(108));
            Console.WriteLine("Contains Value is : " + student.ContainsValue("Om"));
            Console.WriteLine("Count is  : " + student.Count());


            Console.ReadLine();
        }
    }
}
