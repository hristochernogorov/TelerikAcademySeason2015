//Problem 1: Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter the year:");

        int year = Convert.ToInt32(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Leap Year!!!");
        }

        else
            Console.WriteLine("Not a Leap Year!!!");

    }
}

