//Problem 5: Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print number in columns in different notation with some rounding!!!");
        Console.WriteLine("Please enter value of integer number 'a'  as ( 0<= a <= 500)!!!");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter value of number 'b'.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter value of number 'c'.");
        double c = double.Parse(Console.ReadLine());

        if ((0 > a) || (a > 500))
        {
            Console.WriteLine("Incorrect number 'a'.");
        }
        else
        {
            Console.WriteLine("-".PadLeft(80, '-'));
            Console.WriteLine("-".PadLeft(80, '-'));
            Console.WriteLine("THE  RESULT OF CALCULATION\n");
            Console.WriteLine("{0:X}|{1}|{2}|{3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), (b.ToString("F2")), (c.ToString("F3")));
            Console.WriteLine();
        }

    }
}

