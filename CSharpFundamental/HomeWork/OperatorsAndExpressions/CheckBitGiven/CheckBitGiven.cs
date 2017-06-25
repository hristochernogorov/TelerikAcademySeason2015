//Problem 13: Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.

using System;
class CheckBitGiven
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program set 'True' when value of bit 'P' is 1. \n");
        Console.WriteLine("Please enter your integer:");
        int userNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number of bit:");
        int bitP = int.Parse(Console.ReadLine());
        int mask = 1 << bitP;
        int nAndMask = userNum & mask;
        int bit = nAndMask >> bitP;
        bool result = (bit == 1);
        if (result)
        {
            Console.WriteLine(@"The value of bit 'P' is '1' : {0} !!!", result);
        }
        else
            Console.WriteLine(@"The value of bit 'P' is '1' : {0} !!!", result);

    }
}

