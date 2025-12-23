using System;

class practice_question
{
    // Function to calculate power of a number
    static int Power(int baseNum, int exponent)
    {
        int result = 1;
        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNum;
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Input Base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        int powerResult = Power(baseNum, exponent);

        Console.WriteLine($"So, the number {baseNum} ^ (to the power) {exponent} = {powerResult}");
    }
}