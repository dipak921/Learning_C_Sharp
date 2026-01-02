using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class vehicle
    {
        public string brand;
        public int speed;

        public void vehicleinfo()
        {
            Console.WriteLine($"Brand is : {brand} and speed :{speed}");
        }
    }
    class car : vehicle
    {
        public int seatingcpacity;
        public void carinfo()
        {
            Console.WriteLine($"seatingcpacity is : {seatingcpacity}");
        }
    }
    class sportcar : car
    {
        public string fuletype;
        public void sportcarinfo()
        {
            Console.WriteLine($"fuletype is : {fuletype}");
        }
    }

    class f1 : sportcar
    {
        public string f1Name;
        public void f1info()
        {
            Console.WriteLine("F1 Name :" + f1Name);
        }
    }

    internal class multilevel_inheritance
        {
            static void Main(string[] args)
            {
                f1 sportcar = new f1();
                sportcar.fuletype = "cng";
                sportcar.speed = 130;
                sportcar.brand = "toyata";
                sportcar.seatingcpacity = 3;
                sportcar.f1Name = "Skoda Slavia";
                sportcar.sportcarinfo();
                sportcar.vehicleinfo();
                sportcar.carinfo(); 
                sportcar.f1info();
            


             Console.ReadLine();
            }
        }
    }

