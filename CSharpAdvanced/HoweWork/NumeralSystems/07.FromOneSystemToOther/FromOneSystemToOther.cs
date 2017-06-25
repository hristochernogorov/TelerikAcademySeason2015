//Problem 7:Write a program to convert from any numeral system of given base
//s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class FromOneSystemToOther
{
    static void Main()
    {
        ConvertSystem();
    }

    static void ConvertSystem()
    {
        int[] bases = { 2, 8, 10, 16 };
        short[] numbers = { Int16.MinValue, -13621, -18, 12, 19142, Int16.MaxValue };

        foreach (int baseValue in bases)
        {
            Console.WriteLine("Base {0} conversion:", baseValue);
            foreach (short number in numbers)
            {
                Console.WriteLine("   {0,-8}  -->  0x{1}",
                                  number, Convert.ToString(number, baseValue));
            }
        }
    }
}
    
