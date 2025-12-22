using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class file_stream
    {
        static void Main(string[] args)
        {
            //string path = @"C:\stream\sample.text"; // verbatim literal

            ////FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            ////FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            //FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            ////string message = "Hello Student, Welcome to file stream"; 
            //string message = "\nHello ist 2nd message writing"; // append message
            ////byte[] data = Encoding.UTF8.GetBytes(message);
            //byte[] data = Encoding.UTF8.GetBytes(message); // append message
            ////byte[] data = new byte[fs.Length];

            //fs.Write(data, 0, data.Length);
            ////string content = Encoding.UTF8.GetString(data);

            //fs.Close();
            //Console.WriteLine("File Content ");
            ////Console.WriteLine(content);

            //Console.WriteLine("--------copy file-----------------");
            //string path = @"C:\stream\sample.text";
            //string path1 = @"C:\stream\sample_copy.text";
            //using (FileStream source = new FileStream(path, FileMode.Open, FileAccess.Read))
            //using (FileStream destination = new FileStream(path1, FileMode.Create, FileAccess.Write))
            //{
            //    source.CopyTo(destination);
            //}

            //Console.WriteLine("File Copies Successfully");

            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine("Stream Writer...........");
            //string path = @"C:\streamwriter\mytext.text";
            //using(StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine("Hello Student");
            //    sw.WriteLine("File created using stream Writer");
            //}

            //Console.WriteLine("File writeen Successdfully");


            //Console.WriteLine("-------------------------------------------------------");

            //Console.WriteLine("Stream Writer...........");
            //string path = @"C:\streamwriter\studednt_data.text";
            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine("Roll No : 102");
            //    sw.WriteLine("Name : Dipak Rode");
            //}

            //Console.WriteLine("File writeen Successdfully");
            //Console.WriteLine("-------------------------------------------------------");
            //string path = @"C:\streamwriter\studednt_data.text";
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    //string content = sr.ReadLine(); // - ReadLine() reads only the first line of the file
            //    string content = sr.ReadToEnd();  // - - ReadToEnd() reads all the remaining characters from the current position in the file until the end of the file
            //    Console.WriteLine("file Content");
            //    Console.WriteLine(content);
            //}
            Console.WriteLine("------------------------------------------------------------");

            //string path = @"C:\streamwriter\studednt_data.text";
            //using(StreamWriter sw = new StreamWriter(path,true))
            //{
            //    sw.WriteLine("new line added");
            //    sw.WriteLine("date :" + DateTime.Now);

            //}

            //string path = @"C:\streamwriter\user.text";
            //Console.WriteLine("Enter your message");
            //string msg = Console.ReadLine();
            //using(StreamWriter sw = new StreamWriter(path,true))
            //{
            //    sw.WriteLine(msg);
            //}
            //Console.WriteLine("User Input Save");


            string path = @"C:\streamwriter\one_to_five_number.text";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 1; i<= 5; i++)
                {
                   sw.WriteLine(i);
                }
            }
            Console.WriteLine("Print Successfully");




            Console.ReadLine();
        }
    }
}
