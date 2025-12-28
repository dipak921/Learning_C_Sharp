using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class mini_project_
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] marks = new int[n];  // Array to store marks

            // Input marks
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter marks for student {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            // Calculate average, highest, lowest
            int sum = 0;
            int highest = marks[0];
            int lowest = marks[0];
            for (int i = 0; i < n; i++)
            {
                sum += marks[i];
                if (marks[i] > highest) highest = marks[i];
                if (marks[i] < lowest) lowest = marks[i];
            }

            double average = (double)sum / n;

            Console.WriteLine("\n=== Results ===");
            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Highest Marks: {highest}");
            Console.WriteLine($"Lowest Marks: {lowest}");
        }

    }
}
