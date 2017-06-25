//Problem 12: Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFormInteger
{
    static void Main()
    {
        Console.WriteLine("This program finfing value of bit 'P' of some unsigned integer:\n\nPlease enter integer:");
        int userNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number of bit:");
        // bitP --> is bit which the user wants to see.
        int bitP = int.Parse(Console.ReadLine());
        int mask = 1 << bitP;
        int nAndMask = userNum & mask;
        int bit = nAndMask >> bitP;
        Console.WriteLine(" Your integer is: {0} \n You set bit: {1} \n Value of this bit is: {2}", userNum, bitP, bit);
    }
}

