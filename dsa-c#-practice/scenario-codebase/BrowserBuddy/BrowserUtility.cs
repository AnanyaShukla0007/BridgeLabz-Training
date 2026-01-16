using System;

namespace BridgeLabzTraning.BrowserBuddy
{
    internal sealed class BrowserUtility
    {
        private TabHistory history = new TabHistory();
        private ClosedTabStack closedTabs = new ClosedTabStack();

        public void OpenPage()
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();
            history.Visit(url);
        }

        public void Back()
        {
            history.Back();
        }

        public void Forward()
        {
            history.Forward();
        }

        public void CloseTab()
        {
            string current = history.GetCurrent();
            if (current != null)
            {
                closedTabs.Push(current);
                Console.WriteLine("Closed tab: " + current);
            }
            else
            {
                Console.WriteLine("No tab to close.");
            }
        }

        public void RestoreTab()
        {
            string restored = closedTabs.Pop();
            if (restored != null)
            {
                history.Visit(restored);
                Console.WriteLine("Restored tab: " + restored);
            }
            else
            {
                Console.WriteLine("No closed tabs.");
            }
        }
    }
}
