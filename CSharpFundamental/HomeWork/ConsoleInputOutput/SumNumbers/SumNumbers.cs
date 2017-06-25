//Problem 1: Write a program that reads 3 real numbers from the console and prints their sum.


using System;
using System.Globalization;
using System.Threading;

class SumNumbers
{
    static void Main()
    {
        Console.WriteLine("This program sum three  numbers.");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter first real number 'a' :");
        // firstNum is first input real number from user.
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second real number 'b':");
        // secondNum is second input real number from user.
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third real number 'c' :");
        // thirdNum is third input real number from user.
        double thirdNum = double.Parse(Console.ReadLine());
        double sum;
        sum = firstNum + secondNum + thirdNum;
        Console.WriteLine("The sum ot this third real numbers is: {0}", sum);

    }
}

