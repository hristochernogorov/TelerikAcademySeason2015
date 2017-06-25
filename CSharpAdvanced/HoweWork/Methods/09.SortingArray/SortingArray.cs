//Problem 9:Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingArray
{
    static int[] array = new int[] { 12, 3, 8, 21, 43, 57, 33, 11, 5, 16, 74, 86, 74, 96, 66, 91, 27 };

    static void Main()
    {
        MaxElement();
         SortArray();
    }

    static void MaxElement()
    {
        Console.WriteLine("Enter number of index:");
        int index = int.Parse(Console.ReadLine());
        int maxValue = 0;
        for (int i = index; i < array.Length; i++)
        {
            maxValue = array[i];
            Console.Write("{0},", maxValue);
        }
        Console.WriteLine();

    }

    static void SortArray()
    {
        // Sort ascending order.
        Array.Sort(array);
        Console.WriteLine("Ascending sort:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0},", array[i]);
        }
        Console.WriteLine();
        // Sort descending order
        Array.Reverse(array);
        Console.WriteLine("Descending sort:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0},", array[i]);
        }
        Console.WriteLine();

    }
}

