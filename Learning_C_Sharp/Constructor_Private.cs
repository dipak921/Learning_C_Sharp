using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Logger
    {
        private Logger()
        {
            Console.WriteLine("Private Constrctor called");
        }
        public static void WriteLogger()
        {
            Logger logger = new Logger(); // aloowed inside the class
            Console.WriteLine("Log Written Succesfully");
        }
    }
    internal class Constructor_Private
    {
        
        static void Main(string[] args)
        {
            Logger.WriteLogger();


            Console.ReadLine();
        }
    }
}
