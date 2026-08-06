using System;
using System.Collections.Generic;

class QueuePalindrome
{

    Stack<char> stack = new Stack<char>();
    Queue<char> queue = new Queue<char>();


    public void pushCharacter(char ch)
    {
        stack.Push(ch);
    }


    public void enqueueCharacter(char ch)
    {
        queue.Enqueue(ch);
    }


    public char popCharacter()
    {
        return stack.Pop();
    }

    public char dequeueCharacter()
    {
        return queue.Dequeue();
    }
}