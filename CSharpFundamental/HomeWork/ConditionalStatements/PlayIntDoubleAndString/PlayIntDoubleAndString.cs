//Problem 9: Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.


using System;
using System.Globalization;
using System.Threading;

class PlayIntDoubleAndString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print int,double or string by your choise.");
        Console.WriteLine("Please press 1 for int, 2 for double or 3 for string.");
        int inputChoise = int.Parse(Console.ReadLine());
        switch (inputChoise)
        {
            case 1: Console.Write("Please enter a integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2: Console.Write("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b + 1.00);
                break;
            case 3: Console.Write("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
            default: Console.WriteLine("Not correct choice!"); break;
        }


    }

}

