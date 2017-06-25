using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class CompareTextFiles
{
    static void Main()
    {
        string filelocation1 = @"..\..\input1.txt";

        string filelocation2 = @"..\..\input2.txt";

        StreamReader reader1 = new StreamReader(filelocation1);
        StreamReader reader2 = new StreamReader(filelocation2);

        int samelines = 0;
        int differentlines = 0;

        string line1 = reader1.ReadLine();
        string line2 = reader2.ReadLine();

        while (line1 != null)
        {
            if (line1 == line2)
            {
                samelines++;
            }
            else
            {
                differentlines++;
            }

            line1 = reader1.ReadLine();
            line2 = reader2.ReadLine();
        }
        Console.WriteLine("The number of same lines are {0}", samelines);
        Console.WriteLine("The number of different lines are {0}", differentlines);

    }
}

