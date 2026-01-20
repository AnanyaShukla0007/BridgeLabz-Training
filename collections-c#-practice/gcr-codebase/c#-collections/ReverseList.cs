using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList
{
    static void Main()
    {
        // -------- ArrayList --------
        ArrayList arr = new ArrayList { 1, 2, 3, 4, 5 };

        int left = 0, right = arr.Count - 1;
        while (left < right)
        {
            object temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++; right--;
        }

        Console.WriteLine("Reversed ArrayList:");
        foreach (var x in arr) Console.Write(x + " ");

        // -------- LinkedList --------
        LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Stack<int> stack = new Stack<int>();

        foreach (int x in list)
            stack.Push(x);

        list.Clear();
        while (stack.Count > 0)
            list.AddLast(stack.Pop());

        Console.WriteLine("\nReversed LinkedList:");
        foreach (int x in list) Console.Write(x + " ");
    }
}
