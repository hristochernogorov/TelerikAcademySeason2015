//Problem 15: Print your Age now, and your Age after ten years.
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;
using System.Globalization;
using System.Threading;

namespace AgeCalculator
{
    class AgeCalculator
    {
        static void Main()
        {
            CultureInfo bg = new CultureInfo("bg-BG");
            Thread.CurrentThread.CurrentCulture = bg;
            Console.Write("Please enter when is your Birthday in this format dd/MM/yyyy:");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());

            int years = DateTime.Now.Year - birthDay.Year;

            if (DateTime.Now.Month < birthDay.Month)
            {
                Console.WriteLine("Your age now is: {0}", years - 1);
                int firstAge = years - 1;
                Console.WriteLine("Аfter ten years of your age would be: {0}", firstAge + 10);
            }
            else
            {
                Console.WriteLine("Your age now is: {0}", years);
                Console.WriteLine("Аfter ten years of your age would be: {0}", years + 10);
            }
        }
    }
}
