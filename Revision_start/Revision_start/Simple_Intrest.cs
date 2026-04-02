using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class Simple_Intrest
    {
        float p , r, t, si;
           void Intrest()
            {
                Console.WriteLine("Enter the value of p: ");
                p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of r: ");
                r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the value of t: ");
                t = Convert.ToInt32(Console.ReadLine());

                si = (p * r * t) / 100;
                Console.WriteLine("The simple intrest is: " + si);
        } 
            static void Main(string[] args)
            {
                Simple_Intrest obj = new Simple_Intrest();
                obj.Intrest();

                Console.ReadLine();
            }
    }
}
