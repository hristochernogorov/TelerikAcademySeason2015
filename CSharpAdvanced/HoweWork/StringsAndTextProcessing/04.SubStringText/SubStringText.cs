//Problem 4:Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubStringText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        SubString(text);
    }

    static string SubString(string text)
    {
        text.ToLower();
        int count = 0;

        int times = text.IndexOf("in", 0);
        while (times != -1)
        {
            count++;
            times = text.IndexOf("in", times + 1);
        }
        Console.WriteLine(count);
        return text;
    }
}

