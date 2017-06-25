//Problem 11: Write a program that finds the index
//of given element in a sorted array of integers by using the Binary search algorithm.
//examples:
//01,70,54,71,83,51,54,69,16,92,33,48,61,43,52,01,89,19,67,48
//24,47,32,60,99,03,45,02,44,75,33,53,78,36,84,20,35,17,12,50
//19,80,81,68,05,94,47,69,28,73,92,13,86,52,17,77,04,89,55,40
//20,73,35,29,78,31,90,01,74,31,49,71,48,86,81,16,23,57,05,54

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        int[] arrayNumbers = new int[] { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 };

        //low  is the first position in array.
        int low = 0;
        //high is the last position in array.
        int high = arrayNumbers.Length;
        //mid is the medium position in array.
        int mid = (low + high) / 2;
        // searchNumber is  number we are looking.
        int searchNumber = int.Parse(Console.ReadLine());
        // here sort array to prepare it for binary search.

        Array.Sort(arrayNumbers);
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            Console.Write("{0};", arrayNumbers[i]);
        }

        while (searchNumber > 0)
        {
            while (searchNumber < arrayNumbers[mid])
            {

                high = mid;
                mid = (low + high) / 2;
                if (searchNumber == arrayNumbers[mid])
                {
                    Console.WriteLine();
                    Console.WriteLine("The number {0} have index in array: {1}",arrayNumbers[mid],mid);
                }

            }
            while (searchNumber > arrayNumbers[mid])
            {
                low = mid;
                mid = (low + high) / 2;
                if (searchNumber == arrayNumbers[mid])
                {
                    Console.WriteLine();
                    Console.Write("The number {0} have index in array: {1}", arrayNumbers[mid],mid);
                }

            }

        }

    }
}

