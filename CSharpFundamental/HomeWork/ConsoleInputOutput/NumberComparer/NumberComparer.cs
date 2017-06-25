//Problem 4:Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Globalization;
using System.Threading;

class NumberComparer
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program takes number 'a' and number 'b' from user and print the greate of them");
        Console.WriteLine("Please enter first number 'a':");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number 'b':");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("The greater of the numbers is: a = {0}", a);

        }
        else
        {
            Console.WriteLine("The greater of the numbers is: b = {0}", b);
        }

    }
}

