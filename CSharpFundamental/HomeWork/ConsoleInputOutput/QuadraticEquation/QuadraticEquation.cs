//Problem 6: Write a program that reads the coefficients a, b and c 
//of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program calculate x1 and x2 in quadratic equation ax2 + bx + c =0 .");
        Console.WriteLine("Please enter 'a':");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter 'b':");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter 'c':");
        double c = double.Parse(Console.ReadLine());


        double sqrtpart = b * b - 4 * a * c;
        double x, x1, x2, img;
        if (sqrtpart > 0)
        {
            x1 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("Two Real Solutions: x1={0:f1} or x2={1:f1}", x1, x2);
        }
        else if (sqrtpart < 0)
        {
            sqrtpart = -sqrtpart;
            x = -b / (2 * a);
            img = System.Math.Sqrt(sqrtpart) / (2 * a);
            Console.WriteLine("NO REAL ROOTS!!!");
        }
        else
        {
            x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("One Real Solution: {0,8:f4}", x);

        }
    }
}

