//Problem 10:Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;

class NFactorial
{
    static void Main()
    {
        NumberRange();
    }
    static void NumberRange()
    {
        int[] arrayNumbers = new int[100];
        for (int i = 0; i < arrayNumbers.Length + 1; i++)
        {
            int factural = i * i;
            Console.Write("{0},", factural);
        }
        Console.WriteLine();
    }
}

