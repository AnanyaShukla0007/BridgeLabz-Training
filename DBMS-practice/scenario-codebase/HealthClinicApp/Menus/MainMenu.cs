using System;

namespace HealthClinicApp.Menus
{
    /// <summary>
    /// Entry point menu for the application.
    /// </summary>
    public static class MainMenu
    {
        public static void Show()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("WELCOME TO HEALTH CLINIC APP!");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Patient");
            Console.WriteLine("2. Receptionist");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Select role: ");
        }
    }
}
