//Problem 8:Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive


using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("This program check a prime number.");
        Console.WriteLine();
        Console.WriteLine("Please enter your choice:");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        int result = checkPrime(userNumber);
        if (result == 0)
        {
            Console.WriteLine("{0} --> Is NOT a PRIME number!!!", userNumber);
        }
        else
        {
            Console.WriteLine("{0} --> Is a PRIME number!!!", userNumber);
        }
        Console.Read();
    }
    private static int checkPrime(int number)
    {
        int i;
        for (i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                return 0;
            }
        }
        if (i == number)
        {
            return 1;
        }
        return 0;
    }
}

