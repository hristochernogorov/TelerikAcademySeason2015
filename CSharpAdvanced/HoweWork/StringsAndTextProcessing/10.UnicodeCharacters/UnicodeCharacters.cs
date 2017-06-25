//Problem 10:Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:
//input	 |     output
//Hi!	     |   \u0048\u0069\u0021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            answer.AppendFormat("\\u{0:X4}", (int)input[i]);
        }

        Console.WriteLine(answer.ToString());
    }
}

