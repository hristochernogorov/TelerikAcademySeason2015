//Pronlem 3:Write a Boolean expression that checks for given integer if it can be divided.
//(without remainder) by 7 and 5 at the same time.


using System;

class Divide7And5
{
    static void Main()
    {
        Console.WriteLine("This program check some integer if can given by 7 and 5 in same time.");
        int userNum = int.Parse(Console.ReadLine());
        bool result = (userNum % 7 == 0) && (userNum % 5 == 0);
        Console.WriteLine("{0}", result);

    }
}

