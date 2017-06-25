//Problem 11:Write a program that reads two positive integer numbers and prints
//how many numbers p exist between them such that the reminder of the division by 5 is 0.


using System;

class NUmberDividableByGIvenNumbers
{
    static void Main()
    {
        Console.WriteLine("This program reads two positive integers  and print how many numbers 'p' exist \nbetween them division by 5 is 0.");
        Console.WriteLine("Please enter first integer:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second integer:");
        int secondNumber = int.Parse(Console.ReadLine());

        for (int i = firstNumber; i <= secondNumber; i++)

            if (i % 5 == 0)
            {
                Console.WriteLine("The result is: {0}", i);
            }


    }
}

