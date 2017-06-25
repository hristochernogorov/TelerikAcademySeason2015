//Problem 1 B: Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

//b)
//1  8	9	16
//2  7	10	15
//3  6	11	14
//4  5	12	13


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter integer 'n' for matrix rows and columns.");
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        int[,] matrix = new int[n, n];

        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[col, row] = count;
                    count++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[col, row] = count;
                    count++;
                }
            }
        }

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        count = 1;

    }
}

