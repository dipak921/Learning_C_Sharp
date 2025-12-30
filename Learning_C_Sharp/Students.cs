using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class studetn1001
    {
        public int id;
        public string name;
        public int age;

        public void Display()
        {
            Console.WriteLine($"Student id :{id}");
            Console.WriteLine("Name is :" +name);
            Console.WriteLine("Age is :" +age);
        }
    }

    class car1
    {
        public string brand;
        public string color;
        public int maxSpeed;

        public void showDetail()
        {
            Console.WriteLine("Brand Name is :" + brand);
            Console.WriteLine("Brand Name is :" + color);
            Console.WriteLine("Brand Name is :" + maxSpeed);
        }
    }
    internal class Students
    {
        static void Main(string[] args)
        {
            // creating a object of Students 1001 class
            studetn1001 s1 = new studetn1001(); 
            //Assigning values
            s1.id = 101;
            s1.name = "deepak";
            s1.age = 45;
            // Calling methods using object
            s1.Display();

            Console.WriteLine("-------------------------------------------------");
            studetn1001 s2 = new studetn1001();
            s2.id = 102;
            s2.name = "Vishal";
            s2.age = 63;
            s2.Display();
            Console.WriteLine("--------------------- Car -----------------------");
            car1 c1 = new car1();
            c1.brand = "BMW";
            c1.color = "Red";
            c1.maxSpeed = 350;

            car1 c2 = new car1();
            c2.brand = "Range Rover";
            c2.color = "Blue";
            c2.maxSpeed = 450;

            car1 c3 = new car1();
            c3.brand = "Rollcy Roy";
            c3.color = "Black";
            c3.maxSpeed = 280;

            c1.showDetail();
            Console.WriteLine("-------------------------------------------------");
            c2.showDetail();
            Console.WriteLine("-------------------------------------------------");
            c3.showDetail();
            Console.WriteLine("-------------------------------------------------");









            Console.ReadLine();
        }
    }
}
