﻿//Problem 3:Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

namespace MinMaxSumAndAverageNumbers
{
    using System;

    class MinMaxSumAndAveragenumbers
    {
        static void Main()
        {
            Console.Write("Enter the total numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arrNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} No.: ", i + 1);
                arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = arrNumbers[0];
            int max = arrNumbers[0];
            int sum = 0;
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arrNumbers[i];
                if (min > arrNumbers[i])
                    min = arrNumbers[i];
                if (max < arrNumbers[i])
                    max = arrNumbers[i];
            }
            average = (double)sum / n;

            Console.WriteLine();
            Console.WriteLine("Min\t: {0}", min);
            Console.WriteLine("Max\t: {0}", max);
            Console.WriteLine("Sum\t: {0}", sum);
            Console.WriteLine("Average\t: {0,2:n}", average);
        }
    }
}
