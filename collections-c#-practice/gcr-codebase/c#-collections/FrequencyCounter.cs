using System;
using System.Collections.Generic;

class FrequencyCounter
{
    static void Main()
    {
        List<string> words = new List<string>
        { "apple", "banana", "apple", "orange" };

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        foreach (var pair in freq)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
