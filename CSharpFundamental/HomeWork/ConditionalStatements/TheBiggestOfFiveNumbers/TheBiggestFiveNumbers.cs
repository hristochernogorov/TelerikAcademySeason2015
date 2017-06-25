// Problem 6: Write a program that finds the biggest of five numbers by using only five if statements.


using System;
using System.Globalization;
using System.Threading;

class TheBiggestFiveNumbers
{
    static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("This program pritn the biggest number of five input.");
            Console.WriteLine("Please enter first number 'a'.");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first number 'b'.");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first number 'c'.");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first number 'd'.");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first number 'e'.");
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The bigger number is:{0}", a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("The bigger number is:{0}", b);
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine("The bigger number is:{0}", c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("The bigger number is:{0}", d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine("The bigger number is:{0}", e);
            }
    
        }
}

