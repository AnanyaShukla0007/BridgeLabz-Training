using System;
using TechVille.Services.Citizen;

namespace TechVille.ConsoleApp.Menu
{
    public static class CitizenMenu
    {
        public static void Register()
        {
            Console.Write("Citizen Code: ");
            string code = Console.ReadLine();

            Console.Write("Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Income: ");
            decimal income = decimal.Parse(Console.ReadLine());

            Console.Write("Residency Years: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Zone: ");
            string zone = Console.ReadLine();

            CitizenRegistrationService.Register(code, name, age, income, years, zone);
        }

        public static void View()
        {
            Console.Write("Citizen Code: ");
            string code = Console.ReadLine();

            CitizenProfileService.View(code);
        }
    }
}
