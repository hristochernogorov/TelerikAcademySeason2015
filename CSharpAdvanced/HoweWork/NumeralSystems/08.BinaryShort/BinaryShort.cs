//Problem 8:Write a program that shows the binary
//representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryShort
    {
        static void Main()
        {
            Console.WriteLine(" This is binary represention of your integer:");
            Binary();

        }

        static void Binary()
        {
            Console.WriteLine("Enter integer number:");
            int numberInput = int.Parse(Console.ReadLine());
            string binNumber = Convert.ToString(numberInput,2);
            Console.WriteLine(binNumber);
        }
    }

