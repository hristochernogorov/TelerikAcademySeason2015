//Problem 2:Write a program that generates and prints to the console 10 random values in the range [100, 200].


using System;


class RandomNumbers
{
    static void Main()
    {
        //First Variant
        int number = 0;
        Random generator = new Random();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 100; j < 201; j++)
            {
                number = (generator.Next(j));
            }
            Console.WriteLine(number);
        }

        //Second Variant 

        //for (int c = 0; c < 100; c++)
        //{
        //    Console.WriteLine(generator.Next(100, 201));
        //}

    }
}

