//Problem 3: Write a program that reads the radius r of a circle and prints its perimeter
//and area formatted with 2 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculate perimet and area of random circle.\n");
        Console.WriteLine("Please enter value for radius 'r':");
        // the radius is: value input from user.
        double radius = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * (2 * radius);
        double area = Math.PI * (radius * radius);
        Console.WriteLine("The perimeter of circle is: {0}", (perimeter.ToString("F2")));
        Console.WriteLine();
        Console.WriteLine("The area of circle is: {0}", (area.ToString("F2")));
        Console.WriteLine();

    }
}

