using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class File_handling_ex1
    {
        static void Main(string[] args)
        {
            string path = @"C:\Hello\student.txt"; // berbatim literal
            //Console.WriteLine("StreamWriter");

            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(path))
            //    {
            //        sw.WriteLine("Student Name : Kalpesh");
            //        sw.WriteLine("Course : C#");
            //        sw.WriteLine("City : Nashik");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error " + ex.Message);
            //}
            //Console.WriteLine("Append data/without append remove all exsting data");
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(path,true))
            //    {
            //        sw.WriteLine("Student Name : Ram");
            //        sw.WriteLine("Course : Python");
            //        sw.WriteLine("City : Satara");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error " + ex.Message);
            //}

            Console.WriteLine("StremReader");
            using (StreamReader sr = new StreamReader(path))
            {
                //string line;
                //while ((line = sr.ReadLine()) != null)
                //{
                //    Console.WriteLine(line);
                //}

                //OR
                Console.WriteLine(sr.ReadToEnd());
            }


            //Console.WriteLine("Data Written Sucessfulyy");





            Console.ReadLine();
        }
    }
}
