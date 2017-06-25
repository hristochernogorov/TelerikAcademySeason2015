//Problem 9: Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
//Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;

class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine(" This program print sum of numbers.That enter a number 'n' and after that enter\n more n numbers and program print their sum.");
        Console.WriteLine("Please enter number 'n'.");
        double numberN = double.Parse(Console.ReadLine());
        Console.WriteLine("Thanks!!!\nNow enter more 'n' numbers.");
        double result = 0;
        for (double i = 0; i < numberN; i++)
        {
            Console.WriteLine("Your {0} number is: ", i + 1);
            double inputNumbers = double.Parse(Console.ReadLine());
            result += inputNumbers;
        }

        Console.WriteLine("Sum of numbers is: {0}", result);
    }
}

