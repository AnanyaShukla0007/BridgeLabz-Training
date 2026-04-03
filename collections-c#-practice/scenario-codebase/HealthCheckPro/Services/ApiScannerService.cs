using System;
using System.Reflection;
using HealthCheckPro.Attributes;
using HealthCheckPro.Controllers;
using HealthCheckPro.Models;

namespace HealthCheckPro.Services
{
    internal class ApiScannerService
    {
        public ApiMethodInfo[] Scan()
        {
            Type type = typeof(LabController);
            MethodInfo[] methods = type.GetMethods();
            ApiMethodInfo[] results = new ApiMethodInfo[methods.Length];
            int index = 0;

            foreach (MethodInfo method in methods)
            {
                if (method.DeclaringType != type)
                    continue;

                ApiMethodInfo info = new ApiMethodInfo();
                info.MethodName = method.Name;
                info.IsPublic = method.IsDefined(typeof(PublicApiAttribute), false);
                info.RequiresAuth = method.IsDefined(typeof(RequiresAuthAttribute), false);

                results[index++] = info;
            }

            return results;
        }
    }
}
