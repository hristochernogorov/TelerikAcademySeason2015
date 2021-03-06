﻿//Problem 8: Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

using System;
using System.Globalization;
using System.Threading;

class DigitAsWord
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program shows the digit as a word.\nPlease enter digit from 0 to 9.");
        string inputDigit = Console.ReadLine();
        double digit;
        bool parseSuccess = double.TryParse(inputDigit, out digit);

        switch (inputDigit)
        {
            case "0":
                Console.WriteLine("Zero");
                break;
            case "1":
                Console.WriteLine("One");
                break;
            case "2":
                Console.WriteLine("Two");
                break;
            case "3":
                Console.WriteLine("Three");
                break;
            case "4":
                Console.WriteLine("Four");
                break;
            case "5":
                Console.WriteLine("Five");
                break;
            case "6":
                Console.WriteLine("Six");
                break;
            case "7":
                Console.WriteLine("Seven");
                break;
            case "8":
                Console.WriteLine("Eight");
                break;
            case "9":
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Input is not digit!!!");
                break;

        }

    }
}