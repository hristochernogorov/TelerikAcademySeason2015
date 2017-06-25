//Problem 4: Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HexadecimalToDecimal
    {
        static void Main()
        {
            string hexNumber = "126E3";
            Console.WriteLine("Number in hexademical is:126E3");
            int demNumber = Convert.ToInt32(hexNumber, 16);
            Console.WriteLine("The Decical representation is: {0}",demNumber);
        }
    }

