//Problem 3:Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DecimalToHexadecimal
    {
        static void Main()
        {
            int number = 125;
            Console.WriteLine("Number in demical:{0}",number);
            string numberHex = number.ToString("X");
            Console.WriteLine("Number in hexademical:{0}",numberHex);
        }
    }

