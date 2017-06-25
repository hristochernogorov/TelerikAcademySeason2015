//Problem 16: Print Long Sequence.
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet). 
using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int i;
            int j = 1;
            for (i = 0; i < 999; i += 2, j += 2, Console.Write("{0};{1};", i, -j)) ; 
     
        }   
    }
}
