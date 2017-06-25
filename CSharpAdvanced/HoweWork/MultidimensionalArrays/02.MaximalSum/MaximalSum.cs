//Problem 2: Write a program that reads a rectangular matrix of size N x M and finds 
//in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Please enter 'N'.");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 'M'.");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value of matrix separate with space.");
        int[,] matrix = new int[n, m];

     
        // Sample matrix
        //1,-2, 4, 1, -3, 5, 6, -3
        //4, 1, 2, -6, 7, 2, -5, 1
        //3, 1, -4, 3, 6, 1, 2, -2
        //-3, 4, -2, 1, 1, 0, 2, 1
        //-4, 5, 2, 1, 3, -2, 1, 3
        //5, 2, 1, 3, -4, 5, 1, 3
        //2, -3, 4, 2, 1, 2, -1, 5

        if (matrix.GetLength(0) < 3 || matrix.GetLength(1) < 3)
        {
            Console.WriteLine("This is NOT VALID matrix!!!");
            Console.WriteLine("Please enter for 'N'and 'M' number > 3.");
            return;
        }


        else
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                string colsLine = Console.ReadLine();
                string[] cells = colsLine.Split(' ');
                for (int col = 0; col < matrix.GetLength(0); col++)
                {

                    matrix[row, col] = int.Parse(cells[col]);
                }
            }
        }
       

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[col, row]);
            }
            Console.WriteLine();
        }


        //int bestRow = 0;
        //int bestCol = 0;
        int bestSum = int.MinValue;
 
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int newSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (bestSum < newSum)
                {
                    bestSum = newSum;
                    //int bestRow = row;
                    //int bestCol = col;
                }
            }
        }
        //Console.WriteLine("Best matrix is:");
        //Console.WriteLine("{0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
        //Console.WriteLine("{0} {1}", matrix[bestRow +1, bestCol], matrix[bestRow+1, bestCol + 1]);
        Console.WriteLine("Best sum is: {0}", bestSum);
    }
}   

