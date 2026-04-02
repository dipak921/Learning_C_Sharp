using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class PracticeApp
    {
        static void Main(string[] args)
        {
            String data1 = "12052016";
            String data2 = "13062019";

            int d1 = Convert.ToInt32(data1);
            int d2 = Convert.ToInt32(data2);

            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            Console.WriteLine("Differnce of date in year {0}", y2-y1);



            Console.ReadLine();
        }
    }
}
