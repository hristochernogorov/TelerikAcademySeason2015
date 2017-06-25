//Problem 1: Write an expression that checks if given integer is odd or even.


using System;
class OddOrEvenIntegers
{

    static void Main()
    {
        Console.WriteLine("This program check some integers is odd or even.");
        Console.WriteLine("Please enter random integer and press ENTER!!!");
        int someInteger = int.Parse(Console.ReadLine());

        if (someInteger % 2 == 0)
        {
            Console.WriteLine("The integer is ---> EVEN");
        }
        else
        {
            Console.WriteLine("The integer is ---> ODD");
        }

    }
}

