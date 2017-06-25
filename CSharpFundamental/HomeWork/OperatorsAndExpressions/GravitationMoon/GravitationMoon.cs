//Prolem 2: The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.


using System;
using System.Threading;
using System.Globalization;

class GravitationMoon
{
    static void Main()
    {
        Console.WriteLine("This program calculates your weight on the Мoon.");
        Console.WriteLine("based on how your weight is on the ground.");
        Console.WriteLine();
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please enter your weight:");
        //Here I use double because KG may not be an integer.
        double userWeight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight here in Earth is: {0} kg.", userWeight);
        //The moon gravitation is 17% of the Earth.That meen that weight of the Moon is 
        //your weight here * 0.17(this is the representation of 17%.)
        double moonWeight = (userWeight * 0.17);
        Console.WriteLine("Your weight in the MOON will be: {0} kg.", moonWeight);

    }
}

