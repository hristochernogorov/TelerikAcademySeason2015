//Problem 6:Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.



using System;
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("This program calculate digit of some integer number.");
        Console.WriteLine("Please enter four-digit integer:");
        string userNum = Console.ReadLine();
        int userInteger = int.Parse(userNum);

        //Here I do check whether the number starts with zero.
        if (userNum.StartsWith("0"))
        {
            Console.WriteLine("Incorrect number!!! The integer can't start with zero.");
        }
        else
        {
            Console.WriteLine("Your integer is: {0}", userNum);
        }

        int d = userInteger % 10;
        int c = (userInteger / 10) % 10;
        int b = (userInteger / 100) % 10;
        int a = (userInteger / 1000) % 10;

        Console.WriteLine("Sum of digits is = " + (a + b + c + d));
        Console.WriteLine("Reversed order -> " + d + c + b + a);
        Console.WriteLine("Last digit in the first position -> " + d + a + b + c);
        Console.WriteLine("Exchanged second and third digit -> " + a + c + b + d);

    }
}

