using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class jagged_array
    {
        static void Main(string[] args)
        {

            //int[][] arr = new int[3][];
            //arr[0] = new int[] { 1, 52, 83 };
            //arr[1] = new int[] { 4, 15, 6, 57, 8 };
            //arr[2] = new int[] { 9, 10 };

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("enter a number of student :");
            int student_no = Convert.ToInt32(Console.ReadLine());

            int[][] studentMark = new int[student_no][];

            for (int i = 0; i < student_no; i++)
            {
                Console.WriteLine($"Enter a subject{i + 1} :");
                int subjectCount = Convert.ToInt32(Console.ReadLine());

                studentMark[i] = new int [subjectCount];

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.WriteLine($"Enter the mark of subject {j + 1} :");
                    studentMark[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Student Marks");
            for (int i = 0; i < studentMark.Length; i++)
            {
                for (int j = 0; j < studentMark[i].Length; j++)
                {
                    Console.Write(studentMark[i][j]+ " ");
                }
                Console.WriteLine();
            }








            Console.ReadLine();
        }
    }
}
