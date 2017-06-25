//Problem 4:Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{

    static void Main()
        {
            Console.WriteLine("This program calc the surface of triangle by given:");
            Console.WriteLine("CASE 1:By one side and altitude to it !!!");
             Console.WriteLine();
             Console.WriteLine("CASE 2:By two sides and angle between !!!");
             Console.WriteLine();
             Console.WriteLine("CASE 3:By given tree sides of triangle !!!");
             Console.WriteLine();
             Console.WriteLine();
             Console.WriteLine("Enter your choise:");
             int choise = int.Parse(Console.ReadLine());
             switch (choise)
            {
                case 1: ByAltitude();
                    break;
                case 2: ByAngleAndSides();
                    break;
                case 3: ByTreeSide();
                    break; 
            }
            
        }

    static void ByTreeSide()
    {
        Console.WriteLine("Enter side a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side c:");
        int c = int.Parse(Console.ReadLine());
        int p = (a + b + c) / 2;
        int surface =(int) Math.Sqrt(p*(p - a) * (p - b) * (p - c));
        Console.WriteLine("The surfase is: {0}", surface);
    }

    static void ByAltitude()
    {
        Console.WriteLine("Enter side a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter altitude hA:");
        int hA = int.Parse(Console.ReadLine());
        int surface = Math.Abs((a * hA) / 2);
        Console.WriteLine("The surfase is: {0}", surface);
    }

    static void ByAngleAndSides()
    {
        Console.WriteLine("Enter side a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for angle between side 'a' and side 'b':");
        int angle = int.Parse(Console.ReadLine());
        int surface = (int)(a * b * Math.Sin(angle)) / 2;
        Console.WriteLine("The surfase is: {0}", surface);

    }

}

