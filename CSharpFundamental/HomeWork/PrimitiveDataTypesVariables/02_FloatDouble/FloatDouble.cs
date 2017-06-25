//Problem 2: Which of the following values can be assigned to a variable of type float and which to a variable of type double:
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

namespace _02_FloatDouble
{
    class FloatDouble
    {
        static void Main()
        {
            float firstNumber = 12.345F;
            float secondNumber = 3456.091F;
            double thirdNumber = 34.567839023;
            double fourthNumber = 8923.1234857;
            Console.WriteLine("This program shows some numbers:");
            Console.WriteLine(" firstNumber: {0} \n secondNumber: {1} \n thirdNumber: {2} \n fourthNumber: {3} \n",firstNumber,secondNumber,thirdNumber,fourthNumber);

        }
    }
}
