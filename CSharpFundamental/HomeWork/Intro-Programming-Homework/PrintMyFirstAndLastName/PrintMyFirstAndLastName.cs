//Problem 7:Print First and Last Name.
//Create console application that prints your first and last name, each at a separate line.
using System;

namespace PrintMyFirstAndLastName
{
    class PrintMyFirstAndLastName
    {
        static void Main()
        {
            //First decision:
            Console.WriteLine("My Full name is:");
            Console.WriteLine("Gosho");
            Console.WriteLine("Georgiev");
            Console.WriteLine();
      
            //Second decision:
            Console.WriteLine("My Full name is:");
            string firstName = "Gosho";
            string secondName = "Georgiev";
            Console.WriteLine("{0}\n{1}",firstName,secondName);

        }
    }
}
