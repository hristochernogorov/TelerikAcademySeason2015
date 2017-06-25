//Problem 14: We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
//from the binary representation of n while preserving all other bits in n.

using System;
class ModifyBitGiven
{
    static void Main()
    {
        Console.WriteLine("This program calculate value of some bits.\n");
        Console.WriteLine("Please enter  your integer: ");
        // n--> is user integer.
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value V of bit: '0' or '1'");
        // v--> is value of bit 'P' 0 or 1.
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter position of bit 'P':");
        // p --> position of bit which user sets.
        int p = int.Parse(Console.ReadLine());
        //Here i create mask for bitwise operation.
        int mask = 1;
        int result;

        if (v == 1)
        {
            mask = 1 << p;      // v --> is value of bit 'P' 0 or 1.
            result = n | mask;     // n --> is user integer.
        }
        else
        {
            mask = ~(mask << p);   // p --> position of bit which user set.
            result = n & mask;
        }  // Here i represent user integer and result in binary  notation.
        Console.WriteLine("Binary representetion of your int: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("Binary representation of result:   {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("The result is ----> {0}", result); //Here is result of decimal notation.
    }
}

