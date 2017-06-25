using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalAreaSum
{
    static void Main()
    {
        string inputPath = @"..\..\input.txt";
        string outputPath = @"..\..\output.txt";
        StreamReader reader = new StreamReader(inputPath);
        StreamWriter writer = new StreamWriter(outputPath, false);
        int n = int.Parse(reader.ReadLine());

        int[,] matrix = new int[n, n];
        int maxsum = 0;

        for (int i = 0; i < n; i++)
        {
            string[] numbersOnThisLine = new string[n];
            numbersOnThisLine = reader.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(numbersOnThisLine[j]);
            }
        }
        reader.Close();
        maxsum = FindMaxSum(n, matrix, maxsum);

        writer.WriteLine(maxsum);
        writer.Close();

    }

    private static int FindMaxSum(int n, int[,] matrix, int maxsum)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int tempsum = 0;
            for (int j = 0; j < n - 1; j++)
            {
                tempsum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (maxsum < tempsum)
                {
                    maxsum = tempsum;
                }
            }
        }
        return maxsum;
    }

}      
    

