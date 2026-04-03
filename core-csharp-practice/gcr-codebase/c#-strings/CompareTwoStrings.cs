using System;
class CompareTwoStrings
{
    static bool ManualCompare(string s1, string s2)
    {
        if (s1.Length != s2.Length)
            return false;
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine(); //taking input s1
        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine(); //taking input s2
        Console.WriteLine("Manual Compare Result: " + ManualCompare(s1, s2)); //manual comparision
        Console.WriteLine("Built-in Compare Result: " + s1.Equals(s2)); //builtIn comparission
    }
}
