//Problem 3: Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

using System;

namespace _03_VariableHexadecimalFormat
{
    class VariableHexadecimalFormat
    {
        static void Main()
        {
            int hexNumber = 0xFE;
            Console.WriteLine("Tris number in hexademical 0xFE is: {0} in demical",hexNumber);
            Console.WriteLine("Is it true?");
            if (hexNumber == 254)
            Console.WriteLine("TRUE" );
            else 
            Console.WriteLine("FALSE" );

        }
    }
}
