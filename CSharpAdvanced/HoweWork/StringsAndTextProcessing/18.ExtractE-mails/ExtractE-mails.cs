//Problem 18:Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ExtractEmails
{
    static void Main()
    {
        string input = "dada@telerik.com is a very hardly known email adress not as popular as pesho@gmail.com who is using PC and the email gosho@gmail.com dude";
        foreach (var mail in Regex.Matches(input, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(mail);
        }
    }
}

