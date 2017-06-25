//Problem 16* :Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
//of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        uint n;
        byte p, q, k;
        Console.WriteLine("This program exchange bits (p,p+1,....,p+k-1) with bits (q,q+1,....,q+k-1)");
        Console.Write("Please enter unsigned integer number n: ");
        //The input integer from user.
        bool userNum = uint.TryParse(Console.ReadLine(), out n);
        Console.Write("Enter the start position of the first bit sequence p: ");
        // Input value for bit 'p'.
        bool bitP = byte.TryParse(Console.ReadLine(), out p);
        Console.Write("Enter the start position of the second bit sequence q: ");
        // Input value for bit 'q'.
        bool bitQ = byte.TryParse(Console.ReadLine(), out q);
        Console.Write("Enter the lenght of the sequence k: ");
        // Input value for bit 'k'.
        bool bitK = byte.TryParse(Console.ReadLine(), out k);

        if (userNum & bitP & bitQ & bitK)
        {
            if ((p + k) < 31 && (q + k) < 31 && (Math.Abs(p - q) >= k))
            {
                if (p > q)
                {
                    byte temp = q;
                    q = p;
                    p = temp;
                }
                Console.WriteLine("binary initial n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

                n = ((~(((uint)Math.Pow(2, k) - 1) << q | ((uint)Math.Pow(2, k) - 1) << p)) & n) | (((n & (((uint)Math.Pow(2, k) - 1) << p)) << (Math.Abs(p - q))) | ((n & (((uint)Math.Pow(2, k) - 1) << q)) >> (Math.Abs(p - q))));//Swap bits p with bits q
                Console.WriteLine("binary new n:");
                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine("New integer in decimal notation is: {0}", n);
            }
            else
            {
                Console.WriteLine("OVERLAPPING!");
            }
        }
        else
        {
            Console.WriteLine("OUT OF RANGE!");

        }
    }
}
