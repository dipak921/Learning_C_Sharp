using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
