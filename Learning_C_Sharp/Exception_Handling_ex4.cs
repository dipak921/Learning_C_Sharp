using Learning_C_Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Stud
    {
        private int mark;
        public void MarknEnter(int mark)
        {
            if (mark <= 0)
            {
                throw new ArgumentException("Mark is Positve or Zero");
            }
            if (100 > mark)
            {
                throw new ArgumentException("Invalid Mark");
            }

            Console.WriteLine("Add Successfully");
            Console.WriteLine("Remaining Blance is : " + mark);
        }
    }
}

    internal class Exception_Handling_ex4
    {
        static void Main(string[] args)
        { 
            Stud stud = new Stud();
        try
        {
            Console.WriteLine("Enter amount to be withdraw :");
            int m = Convert.ToInt32(Console.ReadLine());
            stud.MarknEnter(m);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Enter error :" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Mark Failed " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Mark add completed ");
        }

        Console.ReadLine();
        }
    }

