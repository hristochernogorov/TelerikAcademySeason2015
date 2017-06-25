//Problem 5:Write a method that checks if the element at given position 
//in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        LargerNeighbours();
    }

    static void LargerNeighbours()
    {
        int[] array = new int[] { 10, 3, 9, 25, 5, 4 };

        for (int i = 1; i < array.Length; i++)
        {

            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
    }
}

