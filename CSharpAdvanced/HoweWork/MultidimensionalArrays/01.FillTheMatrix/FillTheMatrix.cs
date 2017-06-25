//Problem 1 A:Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

//a)
//1	 5	9	13     
//2  6	10	14
//3	 7	11	15
//4	 8	12	16   

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter integer 'n' for matrix rows and columns.");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int count = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = count;
                count++;
            }

        }
        for (int col = 0; col < n; col++)
        {

            for (int row = 0; row < n; row++)
            {
                Console.Write("{0,4}", matrix[col, row]);
            }
            count = 1;
            Console.WriteLine();
        }
    }
}

