//Problem 7: Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

namespace _07_QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string withEcaping = "The \"use\" of quotations causes difficulties.";
            string withQuote = @"The ""use"" of quotations causes difficulties.";

            System.Console.WriteLine(withEcaping);
            System.Console.WriteLine(withQuote);

        }
    }
}
