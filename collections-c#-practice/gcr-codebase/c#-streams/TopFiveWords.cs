using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class TopFiveWords
{
    static void Main()
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.ToLower().Split(
                    new char[] { ' ', '.', ',', '!' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        wordCount[word] = 1;
                }
            }
        }

        var top5 = wordCount
                    .OrderByDescending(x => x.Value)
                    .Take(5);

        foreach (var pair in top5)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
