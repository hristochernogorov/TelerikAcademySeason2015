//Problem 2:Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryToDecimal
    {
        static void Main()
        {
            double sum = 0;
            int n = 1111111; // binary number
            Console.WriteLine("Binary number is: {0}",n);
            int strn = n.ToString().Length; //how many digits has my number
            for (int i = 0; i < strn; i++)
            {
                int lastDigit = n % 10; // get the last digit
                sum = sum + lastDigit * (Math.Pow(2, i));
                n = n / 10; //remove the last digit
            }
            Console.WriteLine("Decimal number is: {0}",sum);
        }
    }

