//Problem 11:Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitwiseExtractBitТhree
{
    static void Main()
    {
        Console.WriteLine("This program finfing value of bit #3 of some unsigned integer:\nPlease enter integer:");
        int userNum = int.Parse(Console.ReadLine());
        int threeBit = 3;
        int mask = 1 << threeBit;
        int nAndMask = userNum & mask;
        int bit = nAndMask >> (threeBit);
        Console.WriteLine("Binary represent of integer:\n{0}", (Convert.ToString(userNum, 2).PadLeft(32, '0')));
        Console.WriteLine("The bit #3 from your integers is: {0}", bit);
    }
}

