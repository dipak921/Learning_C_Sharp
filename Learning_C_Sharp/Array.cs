using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Array
    {
        static void Main(string[] args)
        {
            //int[] number = { 10, 20, 30, 40, 50,60,70,80,90 };
            //Console.WriteLine("Array Element ");
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine($"Elements of index {i} = {number[i]}");
            //}


            // Enter a marks in Display 
            //int[] marks = new int[5];
            //Console.WriteLine("Enter a marks of out 100");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Enter Marks {i + 1}");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Enterd a mark :");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} : {marks[i]}");
            //}



            //string[] names = { "Dipak", "Dinesh", "Jayant", "Shubham", "Yash", "Mahesh" };
            //Console.WriteLine("Names in array");
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //object[] mix = {1,"Dipak",65.24,true};
            //Console.WriteLine("Mixed Array");
            //for (int i = 0; i < mix.Length; i++)
            //{
            //    Console.WriteLine(mix[i]);
            //}


            //int[,] number = {
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9},
            //};
            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write(number[i,j] + "\t " );
            //    }
            //    Console.WriteLine();
            

        //  enter mark form user mark 2 student three subject
        int[,] marks = new int[2, 3];

        Console.WriteLine("Enter marks for 2 student (3 subject)");

        for(int i= 0; i<2;i++)
         {
             Console.WriteLine($"student {i + 1}");

       for(int j=0;j<3;j++)
       {
           Console.Write($"Enter mark {j + 1} :");
           marks[i, j] = Convert.ToInt32(Console.ReadLine());

       }
    Console.WriteLine();
   }

Console.WriteLine("marks enterd:");
for (int i = 0; i < 2; i++)
{
    Console.Write($"student {i + 1}:");
    for (int j = 0; j < 3; j++)
    {
        Console.Write(marks[i, j] + "\t");

    }
    Console.WriteLine();
}

Console.ReadLine();



Console.ReadLine();
        }
    }
}
