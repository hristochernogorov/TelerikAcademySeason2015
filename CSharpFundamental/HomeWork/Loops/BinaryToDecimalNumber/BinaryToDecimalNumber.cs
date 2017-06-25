//Problem 13:Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.


namespace BinaryToDecimalNumber
{
    using System;

    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter binary integer:");
            string binary = Console.ReadLine();
            int[] num = new int[binary.Length];
            long decimalNum = 0;
            long degree = binary.Length - 1;
            for (int i = 0; i < binary.Length; i++)
            {
                char ch = binary[i];
                num[i] = Convert.ToInt32(ch.ToString());
                decimalNum += num[i] * (long)Math.Pow(2, degree);
                degree--;
            }
            Console.WriteLine("{0}", decimalNum);
        }
    }
}
