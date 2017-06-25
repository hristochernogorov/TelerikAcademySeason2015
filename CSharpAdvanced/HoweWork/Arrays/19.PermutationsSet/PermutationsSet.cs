//Problem 19: Write a program that reads a number N and generates and prints all the 
//permutations of the numbers [1 … N].
//Example:

//  N   result
//  3  {1, 2, 3} {1, 3, 2} {2, 1, 3} {2, 3, 1} {3, 1, 2} {3, 2, 1}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PermutationsSet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        bool[] used = new bool[n];

        Dislocation(array, n, used, 0);
    }
    static void Dislocation(int[] array, int n, bool[] used, int index)
    {
        if (index == n)
        {
            Print(array);
        }
        for (int i = 0; i < n; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                array[index] = i + 1;
                Dislocation(array, n, used, index + 1);
                used[i] = false;
            }
        }
    }

    static void Print(int[] array)
    {
        Console.Write(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            Console.Write(" " + array[i]);
        }
        Console.WriteLine();
    }

}

