//Problem 5:Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;
class ThirdDigitSeven
{
    static void Main()
    {
        Console.WriteLine("This program check if third digit from right to left is 7.");
        Console.WriteLine("Please enter some integer:");
        int userNumber = int.Parse(Console.ReadLine());
        string thirdDigit = "7";
        if (userNumber.ToString().Length >= 3 && userNumber.ToString()[userNumber.ToString().Length - 3] == '7')
            Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}

