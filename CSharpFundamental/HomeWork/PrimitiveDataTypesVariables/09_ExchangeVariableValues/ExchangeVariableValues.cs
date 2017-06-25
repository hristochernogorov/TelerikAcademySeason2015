//Problem 9: Declare two integer variables a and b and assign them with 5 and 10
// and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

namespace _09_ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Without change:\n a= {0};\n b= {1}:\n",a,b);
            a = ((a + b) - a);
            b = (a - 5);
            Console.WriteLine("With exchange:\n a= {0};\n b= {1};\n", a, b);

        }
    }
}
