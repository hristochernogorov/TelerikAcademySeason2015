//Problem 11:Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class Number
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int result = 0;
        int r = 0;
        if (b == 2)
        {
            result = a % c;
        }
        else if (b == 4)
        {
            result = a + c;
        }
        else if (b == 8)
        {
            result = a * c;
        }
        int secondResult = 0;
        if ( result % 4 == 0)
        {
            secondResult = result / 4; 
        }
        else
        {
            secondResult = result % 4;
        }
        Console.WriteLine(secondResult);
        Console.WriteLine(result);

    }
}