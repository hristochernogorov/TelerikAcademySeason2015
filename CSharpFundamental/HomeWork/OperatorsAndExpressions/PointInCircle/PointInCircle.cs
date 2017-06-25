//Problem 7:Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).


using System;
using System.Threading;
using System.Globalization;

class PointInCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program checks if point (x;y) is inside a circle.");
        Console.WriteLine();
        Console.WriteLine("Please enter the first value \'X'.");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second value \'Y'.");
        float y = float.Parse(Console.ReadLine());
        //rCircle is: radius of circle.
        float rCircle = 2;
        //dCircle is: diameter of circle.
        float dCircle = (rCircle * rCircle);
        if ((x * x) + (y * y) <= (dCircle))
        {
            Console.WriteLine("The point X and Y is in inside a circle K .");
        }
        else
        {
            Console.WriteLine("The point X and Y is outside a circle K.");
        }
    }
}

