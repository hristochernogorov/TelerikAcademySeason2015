//Problem 19:Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main()
    {
        string input = "Today on 12.11.1988 something happened that changed the events on 05.02.2011";

        foreach (var item in Regex.Matches(input, @"\w+\.\w+\.\w+"))
        {
            Console.WriteLine("{0}", item, CultureInfo.GetCultureInfo("en-CA"));
        }
    }
}

