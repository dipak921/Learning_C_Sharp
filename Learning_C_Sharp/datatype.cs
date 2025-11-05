using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    internal class datatype
    {
        static void Main(string[] args)
        {
            // Value type
            int age = 25; // Integer type
            float height = 5.9f; // Floatin type  - 7
            double weight = 0.12;
            char grade = 'A';
            bool isStudent = true;

            // Refernce Type
            string name = "Dipak";

            // sotre any thing 
            object anything = 230000;


            Console.WriteLine($"my age is {age} and my height is {height}and weight is {weight} grade is {grade} Me is pass  {isStudent} my name is {name} my bank blance is {anything}");

            Console.ReadLine();
        }
    }
}
