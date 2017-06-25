//Problem 2:Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input  |output
//sample |elpmas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter some text");
        string text = Console.ReadLine();
        Console.WriteLine("The reverse representation");
        Reverse(text);

    }

    static string Reverse(string text)
    {
        Console.WriteLine(text.ToCharArray().Reverse().ToArray());
        return text;
    }
       
}

