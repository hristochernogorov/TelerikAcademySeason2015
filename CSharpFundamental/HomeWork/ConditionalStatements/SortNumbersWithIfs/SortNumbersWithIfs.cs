//Problem 7: Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.


using System;
using System.Globalization;
using System.Threading;

class SortNumbersWithIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print 3 number sorted by descending order.");
        Console.WriteLine("Please enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        //firstNumber = a;
        //secondNumber = b;
        //thirdNumber = c;

        if (firstNumber >= secondNumber && firstNumber >= thirdNumber && secondNumber >= thirdNumber)
        {
            Console.WriteLine("{0};{1};{2}", firstNumber, secondNumber, thirdNumber);
        }
        else if (firstNumber >= secondNumber && firstNumber >= thirdNumber && thirdNumber >= secondNumber)
        {
            Console.WriteLine("{0};{1};{2}", firstNumber, thirdNumber, secondNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && firstNumber >= thirdNumber)
        {
            Console.WriteLine("{0};{1};{2}", secondNumber, firstNumber, thirdNumber);
        }
        else if (secondNumber >= firstNumber && secondNumber >= thirdNumber && thirdNumber >= firstNumber)
        {
            Console.WriteLine("{0};{1};{2}", secondNumber, thirdNumber, firstNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && firstNumber >= secondNumber)
        {
            Console.WriteLine("{0};{1};{2}", thirdNumber, firstNumber, secondNumber);
        }
        else if (thirdNumber >= firstNumber && thirdNumber >= secondNumber && secondNumber >= firstNumber)
        {
            Console.WriteLine("{0};{1};{2}", thirdNumber, secondNumber, firstNumber);
        }
    }
}

