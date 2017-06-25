//Problem 6:You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input         	|output
//"43 68 9 23 318"	|461

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumIntegers
{
    static void Main()
    {
        string sequense = Console.ReadLine();
        int[] numbers = sequense.Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(numbers.Sum());
    }

}

