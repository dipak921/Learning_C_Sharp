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
        internal class multilevel_inheritance
        {
            static void Main(string[] args)
            {
         sportcar sportcar = new sportcar();
            sportcar.fuletype = "cng";
            sportcar.speed = 130;
            sportcar.brand = "toyata";
            sportcar.seatingcpacity = 3;
            sportcar.sportcarinfo();
            sportcar.vehicleinfo();
            sportcar.carinfo(); 
            



            }
        }
    }

