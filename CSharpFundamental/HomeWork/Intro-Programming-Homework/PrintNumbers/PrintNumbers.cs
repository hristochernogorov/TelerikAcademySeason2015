﻿﻿//Problem 6: Print Numbers.
//Write a program to print the numbers 1, 101 and 1001, each at a separate line.
//Name the program correctly.
using System;

namespace PrintNumbers
{
    class PrintNumbers
    {
        static void Main()
        {
            // First decision:
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
            //  Second decision:
            Console.WriteLine("{0}\n{1}\n{2}", 1, 101, 1001);
        }
    }
}
