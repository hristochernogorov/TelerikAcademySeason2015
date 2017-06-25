//Problem 4: Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program shows sing ( +,- or 0) of thee real numbers without calculating it.");
        Console.WriteLine("Please enter first real number.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second real number.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third real number.");
        double c = double.Parse(Console.ReadLine());
        if (a < 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("The result is :  - .");
                }
                else
                {
                    Console.WriteLine("The result is :  + .");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("The result is :  - .");
                }
                else
                {
                    Console.WriteLine("The result is :  - .");
                }
            }
        }
        else if (a > 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("The result is :  + .");
                }
                else
                {
                    Console.WriteLine("The result is :  - .");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("The result is :  - .");
                }
                else
                {
                    Console.WriteLine("The result is :  + .");
                }
            }
        }
        else if ((a == 0) || (b == 0) || (c == 0))
        {
            Console.WriteLine("The result is : 0 .");
        }
    }
}

    

