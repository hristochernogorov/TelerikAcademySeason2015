//Problem 2:Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("This program print the greather number of your input.");
        Console.WriteLine("Enter first integer number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second integer number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third integer number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater is:");
        Console.WriteLine(GetMax(GetMax(a, b), c));

    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int biggerNumber = firstNumber;
        if (firstNumber < secondNumber)
        {
            biggerNumber = secondNumber;
        }
        return biggerNumber;

    }
}

