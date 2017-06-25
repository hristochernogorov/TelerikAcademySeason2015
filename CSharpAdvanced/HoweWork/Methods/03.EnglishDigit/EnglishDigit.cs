//Problem 3:Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static void Main()
    {
        PrintDigitAsWord();
    }

    static void PrintDigitAsWord()
    {
        Console.WriteLine("Enter any integer number.");
        int number = int.Parse(Console.ReadLine());
        string numberOfDigits = number.ToString();
        string lastDigit = numberOfDigits.Substring(numberOfDigits.Length - 1);
        int digit = int.Parse(lastDigit);

        string[] allOptions = new string[]
           {
               "zero","one","two","thee","four",
               "five","six","seven","eight","nine" 
           };
        for (int i = 0; i < allOptions.GetLength(0) - 1; i++)
        {

            if (i == digit)
            {

                Console.WriteLine("The last digit is: {0}", allOptions[i]);
            }
        }
    }
}
 
