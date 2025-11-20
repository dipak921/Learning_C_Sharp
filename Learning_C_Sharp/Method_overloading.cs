using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Method_overloading // dyanamic compaile time
    {

        public void Addition()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"sum is : {c}");
        }
        public void Addition(int a , int b)
        {
            int c = a + b;
            Console.WriteLine($"sum is : {c}");
        }
        public void Addition(int a, int b,int e)
        {
            int c = a + b;
            Console.WriteLine($"sum is : {c}");
        }
        public void Addition(int a, double b)
        {
            double c = a + b;
            Console.WriteLine($"sum is : {c}");
        }
        public void Addition(string a, string b)
        {
            string c = a + b;
            Console.WriteLine($"sum is : {c}");
        }
        // HOME WORK
        public void bookroom(string roomtype)
        {
            Console.WriteLine($"Booked room :{roomtype}");
        }
        public void bookroom(int guest, string roomtype)
        {
            Console.WriteLine($"gust is:{guest} room type is : {roomtype}");
        }
        public void bookroom( string roomtype, int guest, Boolean extrapaid)
        {
            Console.WriteLine($"Booked room type is :{roomtype} guest is : {guest} extra paid :{extrapaid}");
        }
        static void Main(string[] args)
        {
            Method_overloading p = new Method_overloading();
            //p.Addition();    // No parameters
            //p.Addition(12,23); // int, int
            //p.Addition(13,24,45); // int, int ,int
            //p.Addition(13,2.4);// int, float
            //p.Addition("dipak", "chande"); // string, string

            p.bookroom("super deleax");
            p.bookroom(4,"lexury");
            p.bookroom("delex",1,true);




            Console.ReadLine();
        }
    }
}
