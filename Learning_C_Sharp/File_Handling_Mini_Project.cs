using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class File_Handling_Mini_Project
    {
        public void addstudentdata()
        {
            string path = @"C:\streamwriter\student_data.text";
            string name;
            double phoneno;
            int rollNo;
            string gender;
            int age;
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Mobile Number :");
            phoneno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Roll No:");
            rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a gender");
            gender = Console.ReadLine();

            Console.WriteLine("Enter a Age");
            age = int.Parse(Console.ReadLine());

            using (StreamWriter n = new StreamWriter(path, true))
            {
                n.WriteLine($"Name : " + name + " Moblile No: "+phoneno+ " Roll No. :" + rollNo +"  Gender : " + gender + " Age :" + age);
            }
            Console.WriteLine("Student data saved successfully!");
        }
        public void viwedata()
        {
            string path = @"C:\streamwriter\student_data.text";
            using (StreamReader sr = new StreamReader(path))
            {
                string content = sr.ReadToEnd();  // - - ReadToEnd() reads all the remaining characters from the current position in the file until the end of the file
                Console.WriteLine(content);
            }
        }
        static void Main(string[] args)
        {

            File_Handling_Mini_Project info = new File_Handling_Mini_Project();

            Console.WriteLine("1. Add Student ");
            Console.WriteLine("2. View Student Data ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                info.addstudentdata();
            }
            else if (option == "2") 
            {
                info.viwedata();
            }
            else 
            {
                Console.WriteLine("Error");
            }



             Console.ReadLine();
        }
    }
}
