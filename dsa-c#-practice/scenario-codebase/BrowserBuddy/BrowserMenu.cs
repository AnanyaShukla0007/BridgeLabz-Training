using System;

namespace BridgeLabzTraning.BrowserBuddy
{
    internal class BrowserMenu
    {
        private BrowserUtility browser = new BrowserUtility();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Open  2.Back  3.Forward  4.Close Tab  5.Restore Tab  6.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        browser.OpenPage();
                        break;
                    case 2:
                        browser.Back();
                        break;
                    case 3:
                        browser.Forward();
                        break;
                    case 4:
                        browser.CloseTab();
                        break;
                    case 5:
                        browser.RestoreTab();
                        break;
                }
            } while (choice != 6);
        }
    }
}
