using System;

namespace TechVille.Services.ServiceManagement
{
    public static class ServiceRequestService
    {
        public static void Request(string citizenCode, string service)
        {
            Console.WriteLine($"Service {service} requested for {citizenCode}");
        }
    }
}
