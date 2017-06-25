//Problem 14:Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerCalculations
{
    static List<int> firstList = new List<int>() { 45,3,28,72 };
    //  {12, 3, 8, 21, 43, 57, 33}
    static void Main()
    {
        MinSumOfNumbers();
        MaxSumOfNumbers();
        Average();
        Product();
    }
    static void MaxSumOfNumbers()
    {
        int maxSum = firstList.Sum();
        Console.WriteLine("Max sum:{0}", maxSum);
    }
    static void MinSumOfNumbers()
    {
        int minSum = 0;
        foreach (var item in firstList)
        {
            if (minSum > item)
            {
                minSum = item;
            }
            Console.WriteLine("Min sum:{0}", minSum);
            return;
        }
    }

    static void Product()
    {
        int productList = 1;
        foreach (var item in firstList)
        {
            productList *= item;
        }

        Console.WriteLine("Product is:{0}", productList);

    }
    static void Average()
    {
        int averageSum = (firstList.Sum() / 2);
        Console.WriteLine("Average is: {0}", averageSum);
    }

}

