using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- Boxing and Unboxing --
        Boxing : means to convert value type to reference type, it is also called implicit
    conversion.
    -- int to Object


    Unboxing : means to convert reference type data to value type is called unboxing concept.
    -- Object to int
     */
    internal class Boxing_Unboxing
    {
        void Boxing()
        {
            int i = 10;
            object o; // Boxing
            o = i; // implicit conversion
            Console.WriteLine(o);

        }
        void Unboxing()
        {
            object o = 10; // Boxing
            int i; // Unboxing
            i = (int)o; // explicit conversion
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Boxing_Unboxing bu = new Boxing_Unboxing();
            bu.Boxing();
            Console.WriteLine("----------------------------------- ");
            bu.Unboxing();







            Console.ReadLine();
        }
    }
}
