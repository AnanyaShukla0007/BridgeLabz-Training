using System;

namespace BridgeLabzTraning.BrowserBuddy
{
    internal class TabHistory
    {
        private HistoryNode current;

        public void Visit(string url)
        {
            HistoryNode newNode = new HistoryNode(url);

            if (current != null)
            {
                current.Next = newNode;
                newNode.Prev = current;
            }
            current = newNode;

            Console.WriteLine("Visited: " + url);
        }

        public void Back()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No previous page.");
            }
        }

        public void Forward()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No next page.");
            }
        }

        public string GetCurrent()
        {
            return current != null ? current.Url : null;
        }
    }
}
