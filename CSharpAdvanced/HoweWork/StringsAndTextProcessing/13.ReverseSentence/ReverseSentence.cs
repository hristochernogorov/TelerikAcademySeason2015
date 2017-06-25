//Problem 13:Write a program that reverses the words in given sentence.
//Example:

//input	                                                output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseSentence
{
    static void Main()
    {
        string originalText = "C# is not C++, not PHP and not Delphi!";
        char lastSighn = originalText[originalText.Length - 1];

        string[] allWords = originalText.Substring(0, originalText.Length - 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < allWords.Length; i++)
        {
            Console.Write(allWords[allWords.Length - 1 - i]);
            Console.Write(" ");
        }
        Console.WriteLine(lastSighn);
    }
}

