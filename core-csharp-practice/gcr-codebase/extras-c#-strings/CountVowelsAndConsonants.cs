using System;
class CountVowelsAndConsonants
{
    static void Count(string s)
    {
        int vowels = 0, consonent = 0 ;
        for(int i=0;i<s.length;i++)
        {
            char c=char.ToLower(s[i]);
            if (c >= 'a' && c <= 'z')
            {
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonent++;
                }
            }
        }
        Console.WriteLine("Vowels: "+vowels);
        Console.WriteLine("Consonants: "+consonants);
    }
    static void Main()
    {
        Console.Write("Enter string: ");
        string s=Console.Readline();
        Count(s);
    }
}