//Problem 1 :Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareRoot
{
    static void Main()
    {
        IsValidNumber((int)userInput);
        SqrtNumber();
    }
  static  double userInput = double.Parse(Console.ReadLine());

    public static void SqrtNumber()
    {
        double result = Math.Sqrt(userInput);
        Console.WriteLine(result);
    }

    public static int IsValidNumber(int number)
    {
        if (userInput<= 0)
        {
            Console.WriteLine("Invalid Number!!!");
        }
        return number;
    }
}

