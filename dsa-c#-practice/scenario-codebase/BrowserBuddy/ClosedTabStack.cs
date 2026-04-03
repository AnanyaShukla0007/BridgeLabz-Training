using System;

namespace BridgeLabzTraning.BrowserBuddy
{
    internal class ClosedTabStack
    {
        private string[] stack = new string[20];
        private int top = -1;

        public void Push(string url)
        {
            stack[++top] = url;
        }

        public string Pop()
        {
            if (top == -1)
                return null;

            return stack[top--];
        }
    }
}
