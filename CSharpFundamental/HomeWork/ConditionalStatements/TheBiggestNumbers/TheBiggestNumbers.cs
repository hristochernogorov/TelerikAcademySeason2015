//Problem 5: Write a program that finds the biggest of three numbers.

using System;
using System.Globalization;
using System.Threading;

class TheBiggestNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print the biggest number of your input.");
        Console.WriteLine("Please enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter first number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter first number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The Biggest number is: {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The Biggest number is: {0}", secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("The Biggest number is: {0}", thirdNumber);
        }
    }
}

