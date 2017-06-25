//Problem 10: Write an expression that checks for given point (x, y)
//if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;
using System.Globalization;
using System.Threading;

class PointInsideOutside
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program check point with cordinates 'X' and 'Y' where is:\nWithin in circle 'K' and outside of rectangle 'R'");
        Console.WriteLine("Please enter cordinat of 'X'");
        double x = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter cordinat of 'Y'");
        double y = Double.Parse(Console.ReadLine());
        // radius of circle.
        double radius = 1.5;
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) < radius * radius)
        {
            if (y > 1)
            {
                Console.WriteLine("The cordinates is inside of circle and outside of rectangle!!!");
            }
            else
            {
                Console.WriteLine("The cordinates is outside of circle and rectangle!!!");
            }

        }
        else
        {
            Console.WriteLine("The cordinates is outside of circle and rectangle!!!");
        }

    }
}

