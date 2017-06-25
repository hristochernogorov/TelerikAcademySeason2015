//Problem 9:Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Threading;
using System.Globalization;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("This program calculates area of trapezoid by two side and hight.");
        Console.WriteLine("Please enter side 'a'.");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        // a--> is first side of the trapezoid.
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side 'b'.");
        // b--> is secont side of the trapezoid.
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter hight 'h'.");
        // h--> is hight of the trapezoid.
        float h = float.Parse(Console.ReadLine());
        float sides = (a + b) / 2;
        float area = sides * h;
        Console.WriteLine("The area of trapezoid is: {0}", area);

    }
}

