//Problem 12:Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char[] alphas = (alphabet + alphabet.ToLower()).ToCharArray();
        string inputWord = Console.ReadLine();
        char[] newInput = inputWord.ToCharArray();
        foreach (char value in newInput)
        {
            Console.WriteLine("Char '{0}' in alphabet is ' {1} ' of position.",value,(int)value - 96);
        }
    }
}

