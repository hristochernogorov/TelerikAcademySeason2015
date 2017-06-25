//Problem 14: Find online more information about ASCII (American Standard Code for Information Interchange)
//and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected.
//You may skip them or display them differently.
using System;
using System.Text;

namespace _14_PrintASCIITable
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("This is the ASCII Table.From character 0 to 255");
            for (int i = 0; i < 256; i++)
            Console.WriteLine("{0} = {1}",i,(char)i);
            {
                
            }
        }
    }
}
