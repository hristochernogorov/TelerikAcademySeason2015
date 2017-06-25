using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ConcatenateTextFiles
{
    static void Main(string[] args)
    {
        string filelocation1 = @"..\..\input1.txt";
        string filelocation2 = @"..\..\input2.txt";

        string destinationfile = @"..\..\output.txt";

        StreamWriter writer = new StreamWriter(destinationfile, false);

        StreamReader readFile1 = new StreamReader(filelocation1);
        StreamReader readFile2 = new StreamReader(filelocation2);

        string currline = null;

        using (writer)
        {
            using (readFile1)
            {
                currline = readFile1.ReadLine();
                while (currline != null)
                {
                    writer.WriteLine(currline);
                    currline = readFile1.ReadLine();
                }
            }

            using (readFile2)
            {
                currline = readFile2.ReadLine();
                while (currline != null)
                {
                    writer.WriteLine(currline);
                    currline = readFile2.ReadLine();
                }
            }
        }
    }
}

