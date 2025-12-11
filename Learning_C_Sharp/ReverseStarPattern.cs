using System;

class ReverseStarPattern
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = rows; i >= 1; i--)
        {
            // Print spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}