//Problem 12:Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string source = "https://telerikacademy.com/";

        int indexOfProt = source.IndexOf("://");
        string protocol = source.Substring(0, indexOfProt);
        protocol = "[protocol] = " + "\"" + protocol + "\"";

        int indexOfServer = source.IndexOf("/", indexOfProt + 3);
        string server = source.Substring(indexOfProt + 3, indexOfServer - indexOfProt - 3);
        server = "[server] = " + "\"" + server + "\"";

        string resource = source.Substring(indexOfServer);
        resource = "[resource] = " + "\"" + resource + "\"";

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);
    }
}

