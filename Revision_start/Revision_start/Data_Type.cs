using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    /*
     -- Data Type --
    Data type : it is used to categorised the data based on pattern and allocate memory space.
    C# language contains two type of data types

    1. Primitive data type : 
       all c and c++ data will be supported by C# as primitive data type
       1.1 int 
       1.2 float
       1.3 double 
       1.4 char
       1.5 bool


    2. Derived data type : this data type enhance to primitive type and create new data
    type  using c# programming under .NET framework
       2.1 Int16, Int32, Int64
       2.2 Double
       2.3 String
       2.4 Class
       2.5 Struct
       2.6 Enum

    Value Type : all primitive data type 
    Reference Type : all derived data type


     */
    internal class Data_Type
    {

        // Derived data type
        void DataType()
        {
            Int16 a = 32767;
            Int32 b = 2147483647;
            Int64 c = 9223372036854775807;
            Double d = 3.14159265358979323846;
            Boolean e = true;
            Char f = 'A';
            String s = "Hello World";
            Object o = 12;
            Console.WriteLine("Int16 value: {0}", a);
            Console.WriteLine("Int32 value: {0}", b);
            Console.WriteLine("Int64 value: {0}", c);
            Console.WriteLine("Double value: {0}", d);
            Console.WriteLine("Boolean value: {0}", e);
            Console.WriteLine("Character value: {0}", f);
            Console.WriteLine("String value: {0}", s);
            Console.WriteLine("Object value: {0}", o);
           
        }
        static void Main(string[] args)
        {
            // value type data types
            int i = 10;
            float f = 3.14f;
            double d = 3.14159265358979323846;
            char c = 'A';
            bool b = true;
            Console.WriteLine("Integer value: {0}", i);
            Console.WriteLine("Float value: {0}", f);
            Console.WriteLine("Double value: {0}", d);
            Console.WriteLine("Character value: {0}", c);
            Console.WriteLine("Boolean value: {0}", b);
            // reference type data types
            string s = "Hello World";
            object o = s; // Boxing
            Console.WriteLine("String value: {0}", s);
            Console.WriteLine("Object value: {0}", o);


            Console.WriteLine("---- Derived Data type ----");
            Data_Type dt = new Data_Type();
            dt.DataType();




            Console.ReadLine();
        }
    }
}
