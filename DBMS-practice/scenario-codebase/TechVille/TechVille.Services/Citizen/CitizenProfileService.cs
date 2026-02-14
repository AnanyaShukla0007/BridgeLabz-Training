using System;
using TechVille.DataAccess;

namespace TechVille.Services.Citizen
{
    public static class CitizenProfileService
    {
        public static void View(string citizenCode)
        {
            var reader = CitizenRepository.GetCitizen(citizenCode);

            if (!reader.Read())
            {
                Console.WriteLine("Citizen not found.");
                return;
            }

            Console.WriteLine("----- Citizen Profile -----");
            Console.WriteLine($"Code : {reader["CitizenCode"]}");
            Console.WriteLine($"Name : {reader["FullName"]}");
            Console.WriteLine($"Age  : {reader["Age"]}");
            Console.WriteLine($"Zone : {reader["Zone"]}");
        }
    }
}
