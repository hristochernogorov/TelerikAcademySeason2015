//Problem 1:Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class CountWords
{
    static void Main()
    {
        int currLine = 0;
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                currLine++;
                if (currLine % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
    }
}




 static List<string> wordsToSearchFor = new List<string>();
        static Dictionary<string, int> countedWords = new Dictionary<string, int>();

        static void Main()
        {
            ReadListOfWordsToSearch();

            CountWordsSearchedFor();

            WriteResult();
        }

        private static void WriteResult()
        {
            var sorted = countedWords.OrderByDescending(x => x.Value);
            StreamWriter writer = new StreamWriter(@"..\..\result.txt", false);
            using (writer)
            {
                foreach (var word in sorted)
                {
                    try
                    {
                        writer.WriteLine("{0} -> {1}", word.Key, word.Value);
                    }
                    catch 
                    {
                        throw new ArgumentException("Something is wrong!");
                    }
                }
            }
        }

        private static void CountWordsSearchedFor()
        {
            StreamReader reader1 = new StreamReader(@"..\..\test.txt");
            using (reader1)
            {
                try
                {
                    string currLine = reader1.ReadLine();
                    while (currLine != null)
                    {
                        string[] words = currLine.Split(new char[] { ' ', ',', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (countedWords.ContainsKey(word))
                            {
                                countedWords[word]++;
                            }
                        }
                        currLine = reader1.ReadLine();
                    }
                }
                catch 
                {
                    throw new ArgumentException("Something is wrong here!");
                }
                
            }
        }

        private static void ReadListOfWordsToSearch()
        {
            try
            {
                StreamReader reader2 = new StreamReader(@"..\..\words.txt");
                using (reader2)
                {
                    string currLine = reader2.ReadLine();
                    while (currLine!=null)
                    {
                        wordsToSearchFor.Add(currLine);
                        currLine = reader2.ReadLine();
                    }
                }
                foreach (string word in wordsToSearchFor)
                {
                    countedWords.Add(word, 0);
                }
            }
            catch
            {
                throw new ArgumentException("Something is wrong here!");
            }
        }
    }