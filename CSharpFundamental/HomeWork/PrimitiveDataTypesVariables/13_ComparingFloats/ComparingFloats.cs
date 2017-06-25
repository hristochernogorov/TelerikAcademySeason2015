//Problem 13: Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

namespace _13_ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            
            Console.WriteLine("This program calculates whether the two real numbers are the same or not!");
            Console.WriteLine("With eps = 0.000001");
            Console.WriteLine("DEPENDING ON YOUR REGIONAL SETTINGS USE: \'.' OR \','!!!");
            Console.WriteLine("Please enter the first number:");
            double  firstNum = Double.Parse(Console.ReadLine());
            Console.WriteLine("You entered: {0}", firstNum);
            firstNum = Math.Round(firstNum, 6);
            Console.WriteLine("But it will be rounded to: {0}", firstNum);
            Console.WriteLine("Please enter the second number:");
            double secondNum = Double.Parse(Console.ReadLine());
            secondNum = Math.Round(secondNum, 6);
            Console.WriteLine("But it will be rounded to: {0}", secondNum);
            Console.WriteLine("Are equal numbers ?");
            double equal = (Math.Abs(firstNum - secondNum));
            if (equal < 0.000001)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");

        }
    }     
}   
