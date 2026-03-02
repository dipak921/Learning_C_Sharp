using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Round
{
    internal class CheckPalindrome02
    {
        static void Main(string[] args)
        {
        string input = "121";
        // Store the string to check

        bool isPalindrome = true;  
        // Assume string is palindrome initially

        for (int i = 0; i<input.Length / 2; i++)  
        // Loop from start to middle of string
        // No need to check full string
        {
            if (input[i] != input[input.Length - 1 - i])  
            // Compare first and last characters
            // Then second and second-last, and so on
            {
                isPalindrome = false;  
                // If mismatch found, it's not palindrome
                break;  
                // Stop loop immediately
            }
}

if (isPalindrome)
    Console.WriteLine("String is Palindrome");
else
    Console.WriteLine("String is Not Palindrome");
    }
}
}