﻿//Problem 14:A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input      |       	output
//.NET	   | platform for applications from Microsoft
//CLR	       |managed execution environment for .NET
//namespace  |hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        dict.Add(".NET", "platform for applications from Microsoft");
        dict.Add("CLR", "managed execution environment for .NET");
        dict.Add("namespace", "hierarchical organization of classes");

        Console.Write("Write the word you want explained or type EXIT to leave : ");
        string input = Console.ReadLine();
        while (input != "EXIT")
        {
            if (dict.ContainsKey(input))
            {
                Console.WriteLine(dict[input]);
            }
            else
            {
                Console.WriteLine("No such explanation found");
            }
            Console.Write("Write the word you want explained or type EXIT to leave : ");
            input = Console.ReadLine();
        }
    }
}


