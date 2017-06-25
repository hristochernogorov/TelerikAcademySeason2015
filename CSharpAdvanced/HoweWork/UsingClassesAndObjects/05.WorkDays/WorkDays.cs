//Problem 5:Write a method that calculates the number of workdays between today and given date,
//passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public
//holidays specified preliminary as array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

public static class WorkDays
{

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime endDay = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("In this period have {0} working days util {1:D}", CalcDay(endDay), endDay);

    }

    public static void ReadConsole()
    {
        DateTime today = DateTime.Today;


        if (endDay < today)
        {
            Console.WriteLine("INVALID DATE!!!");
        }
    }

    public static bool Vacation(this DateTime date)
    {
        // The vacation day is not full list because each year are different.
        DateTime[] vacationDay = {new DateTime(date.Year, 1, 1), new DateTime(date.Year, 1, 2), new DateTime(date.Year, 3, 2), new DateTime(date.Year, 3, 3), 
        new DateTime(date.Year, 4, 10), new DateTime(date.Year, 4, 13), new DateTime(date.Year, 5, 1), new DateTime(date.Year, 5, 6)};
        return vacationDay.Contains(date.Date);
    }

    public static int CalcDay(DateTime endDay)
    {
        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        int workDay = 0;

        while (now != endDay)
        {
            now = now.AddDays(1);
            if (now.DayOfWeek != DayOfWeek.Saturday &&
               now.DayOfWeek != DayOfWeek.Sunday &&
                 !now.Vacation())
            {
                workDay++;
            }
        }
        return workDay;
    }


    public static DateTime endDay { get; set; }
}

