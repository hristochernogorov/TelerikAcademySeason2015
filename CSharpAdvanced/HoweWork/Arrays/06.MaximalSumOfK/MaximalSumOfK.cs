//Problem 6: Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;

class MaximalSumOfK
{
    static void Main()
    {
        Console.Write("Enter value of array N:");
        int n = int.Parse(Console.ReadLine());
        int[] arrayNumbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNumbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter K:");
        int k = int.Parse(Console.ReadLine());
        int bigSum = 0;
        int currentSum = 0;
        int firstIndex = 0;

        for (int i = 0; i < n + 1 - k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                currentSum += arrayNumbers[i + j];
            }
            if (currentSum > bigSum)
            {
                bigSum = currentSum;
                firstIndex = i;
            }
            currentSum = 0;
        }
        Console.WriteLine("The {0} consecutive elements wit max sum are:", k);
        for (int i = firstIndex; i < firstIndex + k; i++)
        {
            Console.Write("{0}, ", arrayNumbers[i]);
        }
        Console.WriteLine("The sum of numbers is: {0}", bigSum);
        Console.WriteLine();
    }
}
