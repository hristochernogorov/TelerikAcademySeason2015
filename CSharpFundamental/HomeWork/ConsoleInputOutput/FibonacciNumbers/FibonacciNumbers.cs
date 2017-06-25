//Problem 10:Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence.
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("This program print the Fibonacci senquence by Limit 'n'.");
        int i, count, f1 = 0, f2 = 1, f3 = 0;
        Console.Write("Please enter the Limit of fibonacci senquence: ");
        count = int.Parse(Console.ReadLine());
        Console.WriteLine(f1);
        Console.WriteLine(f2);
        for (i = 0; i < count - 2; i++)
        {
            f3 = f1 + f2;
            f1 = f2;
            f2 = f3;
            Console.WriteLine(f3);

        }
        Console.ReadLine();
    }
}

