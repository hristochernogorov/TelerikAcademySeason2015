//Problem 10: A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need 
//to learn how to parse dates and times.


using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("This program print when is a  beer time.");
        Console.WriteLine("Please input time in format 'hh:mm  AM or PM'.");
        string inputTime = Console.ReadLine();
        System.Threading.Thread.CurrentThread.CurrentCulture =new CultureInfo("en-US");
        DateTime timeBeer = DateTime.Parse(inputTime);
        DateTime startTime = Convert.ToDateTime("01:00 AM");
        DateTime stopTime = Convert.ToDateTime("03:00 PM");
        if (timeBeer < startTime || timeBeer > stopTime)
        {
            Console.WriteLine("Is not time for Beer.");
        }
        else
        {
            Console.WriteLine("Is time for Beer.");
        }
    }
}

