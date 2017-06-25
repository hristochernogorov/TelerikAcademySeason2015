//Problem 1: Write an if-statement that takes two double variables a and b and exchanges their values if
//the first one is greater than the second one.As a result print the values a and b, separated by a space.



using System;
using System.Globalization;
using System.Threading;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print the greater of two double numbers 'a' and 'b' separate with spase.");
        Console.WriteLine("Please enter first number 'a'.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number 'b'.");
        double b = double.Parse(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine("The result is: {0} {1}.", b, a);
        }
        else
        {
            Console.WriteLine("The result is:{0} {1}",a,b);
        }

    }
}

