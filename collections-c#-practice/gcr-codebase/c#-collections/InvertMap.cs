using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>
        {
            { "A", 1 }, { "B", 2 }, { "C", 1 }
        };

        Dictionary<int, List<string>> inverted =
            new Dictionary<int, List<string>>();

        foreach (var pair in map)
        {
            if (!inverted.ContainsKey(pair.Value))
                inverted[pair.Value] = new List<string>();

            inverted[pair.Value].Add(pair.Key);
        }

        foreach (var pair in inverted)
            Console.WriteLine(pair.Key + " -> " + string.Join(",", pair.Value));
    }
}
