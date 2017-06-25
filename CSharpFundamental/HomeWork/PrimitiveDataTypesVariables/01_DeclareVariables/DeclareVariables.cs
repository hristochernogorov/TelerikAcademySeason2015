//Problem 1: Declare five variables choosing for each of them the most appropriate of the types:
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

namespace _01_DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            byte firstValue = 97;
            sbyte secondValue = -115;
            short thirdValue = -10000;
            ushort fourthValue = 52130;
            int fifthValue = 4825932;
            Console.WriteLine("This program shows some primitive data and types and their value.");
            Console.WriteLine(" byte= {0} \n sbyte= {1} \n short= {2} \n ushort= {3} \n int= {4} \n",firstValue,secondValue,thirdValue,fourthValue,fifthValue);
        }
    }
}
