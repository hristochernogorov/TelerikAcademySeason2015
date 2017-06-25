//Problem 3:Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArray
{
    static void Main()
    {
        Console.WriteLine("Enter the first arrays of char:");
        string firstInput = Console.ReadLine().ToLower();

        Console.WriteLine("Enter the second arrays of char:");
        string secondInput = Console.ReadLine().ToLower();

        int lengthOfString = Math.Min(firstInput.Length, secondInput.Length);

        for (int i = 0; i < lengthOfString; i++)
        {
            if (firstInput[i] == secondInput[i])
            {
                Console.WriteLine("The -->> " + firstInput[i] + " char of first array is same with char -->>"  + secondInput[i] +
                    "  of second array.");
            }
            else if (firstInput[i] != secondInput[i])
            {
                Console.WriteLine("The -->> " + firstInput[i] + " char of first array is not same with char -->> " + secondInput[i] +
                    "  of second array.");
            }
        }
    }
}
