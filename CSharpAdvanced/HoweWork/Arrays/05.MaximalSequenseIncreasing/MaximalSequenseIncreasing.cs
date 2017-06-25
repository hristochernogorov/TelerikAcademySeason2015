//Problem 5: Write a program that finds the maximal increasing sequence in an array.
//Example:

//input              |	result
//3, 2, 3, 4, 2, 2, 4|	2, 3, 4

using System;

class MaximalSequenseIncreasing
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght:");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] arr = new int[arrLenght];
        int count = 0;
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            count ++;
            if (arr[i] < arr[i + 1] && arr[i + 1] < arr[ i + 2 ])
            {

                Console.WriteLine("Maximal sequence of numbers is: {0},{1},{2}", arr[i], arr[i + 1], arr[i + 2]);
                break;
            }
            else
            {
                Console.WriteLine("Don't have any maximal increasing sequence!!!");
                break;
            }
        }
    }
}