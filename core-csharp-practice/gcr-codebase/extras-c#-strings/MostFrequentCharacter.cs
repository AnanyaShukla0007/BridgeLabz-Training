using System;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        int maxCount = 0;
        char maxChar = s[0];

        for (int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < s.Length; j++)
                if (s[i] == s[j])
                    count++;

            if (count > maxCount)
            {
                maxCount = count;
                maxChar = s[i];
            }
        }

        Console.WriteLine("Most Frequent Character: " + maxChar);
    }
}
