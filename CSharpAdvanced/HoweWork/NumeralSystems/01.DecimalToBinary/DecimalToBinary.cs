//Problem 1:Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter integer:");
        Console.Write("Decimal numeral system: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        int remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("Binary representation:  {0}", result);

    }
}

