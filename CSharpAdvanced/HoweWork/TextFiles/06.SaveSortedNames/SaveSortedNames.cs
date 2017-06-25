using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



class SaveSortedNames
{
    static void Main(string[] args)
    {
        StreamReader read = new StreamReader(@"..\..\input.txt");
        StreamWriter write = new StreamWriter(@"..\..\output.txt");

        List<string> allLines = new List<string>();
        string currLine = read.ReadLine();

        while (currLine != null)
        {
            allLines.Add(currLine);
            currLine = read.ReadLine();
        }
        read.Close();
        allLines.Sort();

        foreach (string line in allLines)
        {
            write.WriteLine(line);
        }
        write.Close();
    }
}

