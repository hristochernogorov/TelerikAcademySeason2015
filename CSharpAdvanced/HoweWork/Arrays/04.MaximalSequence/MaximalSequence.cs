//Problem 4:Write a program that finds the maximal sequence of equal elements in an array.
//Example:
//input                        |	result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1 |	2, 2, 2


using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght:");
        int arrLenght = int.Parse(Console.ReadLine());
        string[] arr = new string[arrLenght];
        Console.WriteLine("Enter array element and press enter:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine();
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == arr[i + 1] && arr[i] == arr[i + 2])
            {
                Console.WriteLine("Maximal sequence of numbers is: {0},{1},{2}", arr[i], arr[i + 1], arr[i + 2]);
                break;
            }

        }
    }
}

