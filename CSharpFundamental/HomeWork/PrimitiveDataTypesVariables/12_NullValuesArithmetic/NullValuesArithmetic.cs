//Problem 12: Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

namespace _12_NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            double? nullValueDouble = null;
            int? nullValueInt = null;
            Console.WriteLine("This  is the result of the first condition of the task: \n {0} \n {1}",nullValueDouble,nullValueDouble );
            nullValueDouble  = 5;
            nullValueInt  = 18;
            Console.WriteLine("This is the result of the second condition of the task: \n {0} \n {1}",nullValueInt,nullValueDouble  );
        
        }
    }
}
