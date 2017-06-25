// Problem 2:Write a program that enters from the console a positive integer n and prints all the numbers
//from 1 to n not divisible by 3 and 7, on a single line, separated by a space 


namespace NumbersNotDivisibleByTreeAndSeven
{
    using System;

    class NumberNotDivisible
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
          
        }
    }
}
