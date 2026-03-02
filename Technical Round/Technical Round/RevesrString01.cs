using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Round
{
    internal class RevesrString01
    {
        static void Main(string[] args)
        {
            string input = "Dipak";
            // Declare a string variable named 'input' and assign value "Dipak"

            string reversed = "";
            // Create an empty string to store the reversed result

            for (int i = input.Length - 1; i >= 0; i--)
            // Start loop from last character index
            // input.Length - 1 gives last index
            // Loop runs until index is >= 0
            // i-- means decrease index each time
            {
                reversed += input[i];
                // Add each character from end to start into reversed string
            }

            Console.WriteLine(reversed);
            // Print the reversed string on console
        }
    }
}
