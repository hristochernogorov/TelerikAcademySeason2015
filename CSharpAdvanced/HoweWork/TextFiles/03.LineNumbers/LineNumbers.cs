using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string filelocation = @"..\..\input.txt";

            string destinationfile = @"..\..\output.txt";

            StreamWriter writer = new StreamWriter(destinationfile, false);

            StreamReader reader = new StreamReader(filelocation);

            using (reader)
            {
                using (writer)
                {
                    string currLine = reader.ReadLine();
                    int line = 1;
                    while (currLine != null)
                    {
                        writer.WriteLine(line + ". " + currLine);
                        currLine = reader.ReadLine();
                        line++;
                    }
                }
            }
        }
    }
}
