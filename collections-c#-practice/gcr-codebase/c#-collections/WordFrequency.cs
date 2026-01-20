using System;
using System.Collections.Generic;

class WordFrequency
{
    static void Main()
    {
        string text = "Hello world hello Java";
        string[] words = text.ToLower().Split(' ');

        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (map.ContainsKey(word))
                map[word]++;
            else
                map[word] = 1;
        }

        foreach (var pair in map)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
