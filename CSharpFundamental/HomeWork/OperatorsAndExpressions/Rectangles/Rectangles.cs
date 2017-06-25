//Problem 4: Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;
using System.Threading;
using System.Globalization;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("This program calculate perimeter and area of rectangle.");
        Console.WriteLine("Enter the Width:");
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double userWigth = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Height:");
        double userHeight = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of this rectangle is:");
        double perimeter = (userWigth + userHeight) * 2;
        Console.WriteLine(perimeter);
        Console.WriteLine("The area of this rectangle is:");
        double area = (userHeight * userWigth);
        Console.WriteLine(area);

    }
}

