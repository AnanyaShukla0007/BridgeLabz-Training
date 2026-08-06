using System;
using System.Collections.Generic;

class ReverseAString
{
    static void Main()
    {
        string str = Console.ReadLine();

        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
        {
            stack.Push(ch);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}