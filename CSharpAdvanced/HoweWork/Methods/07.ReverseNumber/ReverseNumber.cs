//Problem 7:Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main()
    {
        ReverseMetod();
    }

    static void ReverseMetod()
    {
        Console.WriteLine("Please enter integer number of TWO digit:");
        decimal input = decimal.Parse(Console.ReadLine());
        string number = input.ToString();
        for (int i = 0; i < number.Length; i++)
        {
            Console.WriteLine("{0}{1}", number[i + 1], number[i]);
            return;
        }
    }
}

