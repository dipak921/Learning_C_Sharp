using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_start
{
    internal class Student_MarkSheet_Application
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Roll Number : ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Class : ");
            string className = Console.ReadLine();

            Console.WriteLine("Enter your Marks of Marathi : ");
            int Marathi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Marks of Math : ");
            int Math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Marks of Physis : ");
            int Physic = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Marks of Chemistry : ");
            int Chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Marks of English : ");
            int English = Convert.ToInt32(Console.ReadLine());

            int obtainedMarks = Marathi + Math + Physic + Chem + English;
            int totalMarks = 500;
            double percentage = (obtainedMarks / (double)totalMarks) * 100;

            Console.WriteLine("-------------------- MarkSheet ---------------------------");
            Console.WriteLine("your name is  : {0}", name);
            Console.WriteLine("your roll number is : {0}", rollNumber);
            Console.WriteLine("your class is : {0}", className);
            Console.WriteLine("Your obtain mraks are {0}", obtainedMarks);
            Console.WriteLine("Your percentage is {0} %", percentage);

            // Grade Calculation
            if (percentage >= 80)
            {
                Console.WriteLine("Your Grade is A+");
            }
            else if (percentage >= 60 && percentage < 80)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (percentage >= 35 && percentage < 50)
            {
                Console.WriteLine("Your Grade is C");
            }
            else
            {
                Console.WriteLine("Your Grade is Fail");
            }

            // for Remrks
            if (percentage >= 80)
            {
                Console.WriteLine("Remark : Excelletn");
            }
            else if (percentage >= 60 && percentage < 80)
            {
                Console.WriteLine("Remark : Very Good");
            }
            else if (percentage >= 50 && percentage < 60)
            {
                Console.WriteLine("Remark : Good");
            }
            else if (percentage >= 35 && percentage < 50)
            {
                Console.WriteLine("Remark : Need Improvement");
            }
            else
            {
                Console.WriteLine("Remark : Poor");
            }

            // for Pass or Fail
            int back = 0;
            if(Marathi < 35)
            {
                back++;
            }
            if (Math < 35)
            {
                back++;
            }
            if (Physic < 35)
            {
                back++;
            }
             if (Chem < 35)
            {
                back++;
            }
            if (English < 35)
                {
                    back++;
            }

            Console.WriteLine("Your are Failed in {0} subject", back);



        }
    }
}
