//Problem 4: Declare a character variable and assign it with the symbol that has
//Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

using System;

namespace _04_UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            char unicodeChar = '\u002A';
            Console.WriteLine(unicodeChar);
            if (unicodeChar == '*')
                Console.WriteLine("This character is :TRUE");
            else
                Console.WriteLine("This character is :FALSE");
 
        }
    }
}
