//Problem 1 D::Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//d)
//1	12	11	10
//2	13	16	9
//3	14	15	8
//4	5	6	7

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
        int[,] matrix = new int[n,n];
        int digit = 1;
        int offset = 0;
        int ROW = 0;
        int COL = 0;
        while (digit <= n * n)            
        {
            for (ROW = offset; ROW < n - offset; ROW++)
            {
                COL = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = 1 + offset; COL < n - offset; COL++)
            {
                ROW = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (ROW = n - 2 - offset; ROW >= offset; ROW--)
            {
                COL = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = n - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            offset++;
        }
        //Here is code for display matrix.
        for (int irow = 0; irow < n; irow++)           
        {
            for (int column = 0; column < n; column++)
            {
                Console.Write("{0, 4}", matrix[irow, column]);
            }
            Console.WriteLine();
        }
    }
}

