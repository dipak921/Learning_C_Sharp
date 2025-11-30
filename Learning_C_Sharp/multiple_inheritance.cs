using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    interface IFather1
    {
        void Teach(string subject, int hours);
        void Guid(string topic);
    }
    interface IFather2
    {
        void play(string game, int duration);
        void Encourage(string Activity);
    }
    public class Child : IFather1, IFather2
    {
        public void Teach(string subject, int hours)
        {
            Console.WriteLine($"Father teach a core subject {subject} for {hours} form father one");
        }
        public void Guid(string topic)
        {
            Console.WriteLine($"Guid her father his {topic}");
        }
        public void play(string game, int duration)
        {
            Console.WriteLine($"playing a game father 2 {game} , {duration} in month");
        }
        public void Encourage(string Activity)
        {
            Console.WriteLine($"Father 2 is echourage this activity {Activity}");
        }
    }
    internal class multiple_inheritance
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Teach("Math", 3);
            c.Guid("History");
            c.play("Cricket", 40);
            c.Encourage("TeamWork");


            Console.ReadLine();
        }
    }
}
