//Problem 23:Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                 output
//aaaaabbbbbcdddeeeedssaa	abcdedsa


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SeriesOfLetters
{
    static void Main()
    {
        string input = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder answer = new StringBuilder();
        answer.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                answer.Append(input[i]);
            }
        }
        Console.WriteLine(answer.ToString());
    }
}

