//Problem 2:Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter lenght of two Array:");
        //Here read size ot two arr.
        int sizeOfArrays = int.Parse(Console.ReadLine());

        int[] firstArr = new int[sizeOfArrays];
        int[] secondArr = new int[sizeOfArrays];

        for (int i = 0; i < sizeOfArrays; i++)
        {
            Console.WriteLine("Enter Element  " + (i + 1) + " of first string?");
            firstArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < sizeOfArrays; i++)
        {
            Console.WriteLine("Enter Element " + (i + 1) + " of second string?");
            secondArr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        for (int i = 0; i < sizeOfArrays; i++)
        {
            if (firstArr[i] > secondArr[i])
            {
                Console.WriteLine("Element " + (i + 1) + " ------->> " + firstArr[i] + " > " + secondArr[i]);
            }
            else if (firstArr[i] < secondArr[i])
            {
                Console.WriteLine("Element" + (i + 1) + " ------->> " + firstArr[i] + " < " + secondArr[i]);
            }
            else //(firstArr[i] = secondArr[i])
            {
                Console.WriteLine("Element " + (i + 1) + " ------->> " + firstArr[i] + " = " + secondArr[i]);
            }

        }


    }
}

