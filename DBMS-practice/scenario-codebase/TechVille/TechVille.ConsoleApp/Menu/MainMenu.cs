using System;

namespace TechVille.ConsoleApp.Menu
{
    public static class MainMenu
    {
        public static void Show()
        {
            while (true)
            {
                Console.WriteLine("\n--- TECHVILLE SMART CITY ---");
                Console.WriteLine("1. Register Citizen");
                Console.WriteLine("2. View Citizen");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CitizenMenu.Register();
                        break;
                    case 2:
                        CitizenMenu.View();
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
