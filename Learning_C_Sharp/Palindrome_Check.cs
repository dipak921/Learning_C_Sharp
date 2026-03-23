using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    internal class Palindrome_Check
    {
        /*
            What is palindrome 
         -> A palindrome is a word that reads the same backward or forward
            ex. radar, civic,madam, level
        non-palindrome 
        dipaK, nikita, sonali, pandurang
         */
        static void Main(string[] args)
        {
            
            string r_str = "";
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();
            str = str = str.ToLower();// convert all letter in small case

            for (int i = str.Length - 1; i>=0; i--)
            {
                r_str += str[i];
            }
            // check palindrome
            if(r_str == str)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
           







            Console.ReadLine();
        }
    }
}
