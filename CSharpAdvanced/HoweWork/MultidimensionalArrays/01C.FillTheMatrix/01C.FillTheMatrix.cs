//Problem 1 C:Write a program that fills and prints a matrix of size (n, n) as shown below:
////Example for n=4:
//c)
//7	11	14	16
//4	8	12	15
//2	5	9	13
//1	3	6	10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {

        // Variant C
        Console.WriteLine("Please enter integer 'n' for matrix rows and columns.");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int rows = 0;
        int cols = 0;
        int value = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = value++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = value++;
            }
        }


        for (int c = 0; c < n; c++)
        {
            for (int r = 0; r < n; r++)
            {
                Console.Write("{0, 4}", matrix[c, r]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

