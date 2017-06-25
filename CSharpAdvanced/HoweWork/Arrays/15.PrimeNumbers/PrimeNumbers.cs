//Problem 15:Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var primes = new bool[num + 1];
       // int num = int.Parse(Console.ReadLine());
        // init candidates  
        for (int i = 2; i <= num; i++) { primes[i] = true; }

        // cross-out 2's:  
        //   2, 4, 6, 8, 10...  
        // cross-out 3's:  
        //   9, 12, 15...  
        for (int i = 2; (i * i) <= num; i++)
        {
           // Console.WriteLine("Crossing out {0}'s to {1}:", i, num);

            for (int j = i * i; j <= num; j = j + i)
            {
                //Console.WriteLine(" * crossing-out: {0}", j);
                primes[j] = false;
            }
        }

        Console.WriteLine("Results: prime numbers between 1 and {0}:", num);
        for (int i = 2; i <= num; i++)
        {
            if (primes[i]) Console.WriteLine(" * {0} ", i);
        }
    }
}

