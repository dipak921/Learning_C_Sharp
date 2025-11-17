using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    enum Days
    {
        Sunday, //0
        Monday, // 1
        Tuesday, // 2
        Wednesday, // 3 
        Thursday, // 4
        Friday, // 5
        Saturday //6
    }
    internal class Enum_c_sharp
    {
        // C# Enum
        // --> Enum is a set of Constants
        // --> An enum is a special "class" that represents a group of constant (unchangeable / read-only variable)
        // --> enum is short for "enumerations", Which means "specifically Listed"
        // --> in c# an enum (or enumeration type)is used to assign contant names to a group of numeric integer values.
        // --> It makes constant values more readable for example, WeekDays.Mondya is more readable then number 0 when referring t the day in a week
        // --> An enum is defined using the enum keyword, directly inside a namespace, class, or structure. All the constant names can be declared inside the curly brackets and separated by a comma.
        // --> The default underlying type of an enum is int.
        //--> The default value for first element is zero and gets incremented by 1.
        //--> Enum are value types.
        //--> Enum is more readable and maintainable.
        //--> Enum is converted into abstract class behind the scenes.

        // HOW TO CREATE ENUM IN C#
        // --> To create an enum, use the enum keyword (instead of class or interface),and separate the enum items with a comma.
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("My Name is dipak");


            //Console.WriteLine(Days.Sunday);

            Days birthday = Days.Sunday;
            Console.WriteLine(birthday);




            Console.ReadLine();
        }
    }
}
