using System;
using TechVille.Services.ServiceManagement;

namespace TechVille.ConsoleApp
{
    public static class ServiceMenu
    {
        public static void RequestService()
        {
            Console.Write("Citizen Code: ");
            string code = Console.ReadLine();

            Console.Write("Service Name: ");
            string service = Console.ReadLine();

            ServiceRequestService.Request(code, service);
        }
    }
}
