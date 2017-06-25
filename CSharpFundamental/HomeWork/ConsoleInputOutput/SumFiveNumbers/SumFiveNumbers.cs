//Problem 7:Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Linq;
using System.Globalization;
using System.Threading;

class SumFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculate the sum of 5 number from console.");
        Console.WriteLine("Please enter five one-digit numbers with spase distance between them:");
        string[] fiveNumbers = Console.ReadLine().Split();
        double a = Convert.ToDouble(fiveNumbers[0]);
        double b = Convert.ToDouble(fiveNumbers[1]);
        double c = Convert.ToDouble(fiveNumbers[2]);
        double d = Convert.ToDouble(fiveNumbers[3]);
        double e = Convert.ToDouble(fiveNumbers[4]);
        Console.WriteLine("The sum of numbers is:{0:F2}", a + b + c + d + e);

    }

}

