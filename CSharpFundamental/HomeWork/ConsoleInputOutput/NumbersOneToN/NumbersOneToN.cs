//Problem 8:Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n],
//each on a single line.
//Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

class NumbersOneToN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print integer number from 1 to your input number 'n' each number in separate line.");
        Console.WriteLine("Please enter your integer 'n'.");
        int userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The result is:");
        for (int i = 1; i < userNumber + 1; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}

