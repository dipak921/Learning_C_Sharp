using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class SumDateDigit
    {
        static void Main(string[] args)
        {
            String data1 = "12052016";
            
            int d1 = Convert.ToInt32(data1);
            int sum = 0;
            while(d1 != 0)
            {
                int first = d1 % 10;
                d1 = (int)(d1 / 10);
                sum = sum + first;
            }

            Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
