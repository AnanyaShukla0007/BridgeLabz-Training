using System;
using HealthCheckPro.Models;

namespace HealthCheckPro.Utilities
{
    internal class DocumentationGenerator
    {
        public void Generate(ApiMethodInfo[] methods)
        {
            Console.WriteLine("API Documentation:");

            foreach (ApiMethodInfo info in methods)
            {
                if (info == null) continue;

                if (!info.IsPublic)
                    Console.WriteLine(info.MethodName + " ❌ Missing @PublicApi");
                else
                    Console.WriteLine(info.MethodName +
                        (info.RequiresAuth ? " 🔐 RequiresAuth" : " 🌐 Public"));
            }
        }
    }
}
