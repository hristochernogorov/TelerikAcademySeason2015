using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    class PrefixTest
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            List<string> answer = new List<string>();

            string currLine = reader.ReadLine();

            while (currLine != null)
            {
                int index = currLine.IndexOf("Test");
                if (index != -1)
                {
                    if ((currLine[index + 4] != ' ') && (currLine[index + 4] != '.') && (currLine[index + 4] != ',') && (currLine[index + 4] != '-'))
                    {
                        currLine = currLine.Substring(0, index) + currLine.Substring(index + 4);
                    }
                }
                index = -1;
                index = currLine.IndexOf("test");
                if (index != -1)
                {
                    if ((currLine[index + 4] != ' ') && (currLine[index + 4] != '.') && (currLine[index + 4] != ',') && (currLine[index + 4] != '-'))
                    {
                        currLine = currLine.Substring(0, index) + currLine.Substring(index + 4);
                    }
                }
                answer.Add(currLine);
                currLine = reader.ReadLine();
            }

            reader.Close();

            StreamWriter writer = new StreamWriter(@"..\..\input.txt", false);

            foreach (string item in answer)
            {
                writer.WriteLine(item);
            }

            writer.Close();
        }
    }

