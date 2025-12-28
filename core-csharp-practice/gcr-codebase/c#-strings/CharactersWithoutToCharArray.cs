using System;
class CharactersWithoutToCharArray
{
    static void PrintCharacters(string s)
    {
        for (int i = 0; i < s.Length; i++) //looping
        {
            Console.WriteLine(s[i]); //output
        }
    }
    static void Main()
    {
        Console.Write("Enter string: "); 
        string s = Console.ReadLine(); //input
        PrintCharacters(s);
    }
}
