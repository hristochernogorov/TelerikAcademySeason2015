//Problem 25:Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:
//Title: News
//Text: Telerik Academy aims to provide free real-world practical training for young people
//who want to turn into skilful .NET software engineers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExtractTextFromHTML
{
    static void Main()
    {
        string source = @"<html>
  <head><title>News</title></head>
  <body><p><a href=""http://academy.telerik.com"">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>";
        StringBuilder answer = new StringBuilder();
        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] == '<')
            {
                while (source[i] != '>')
                {
                    i++;
                }
                continue;
            }
            answer.Append(source[i]);
        }
        Console.WriteLine(answer.ToString().Trim());
        Console.WriteLine();
    }
}

