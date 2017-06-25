//Problem 6: Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryToHexadecimal
    {
        static void Main()
        {
            string binNumber = "1011";
            Console.WriteLine("Number in Binary representation: {0}",binNumber);
            var hexNumber = Convert.ToInt32("1011", 2).ToString("X");
                Console.WriteLine("Number in Hexadecimal representation:{0}",hexNumber);
        }
    }

