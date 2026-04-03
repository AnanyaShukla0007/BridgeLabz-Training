using System;
using System.Reflection;
using EventTracker.Actions;
using EventTracker.Attributes;
using EventTracker.Models;

namespace EventTracker.Services
{
    internal class AuditScannerService
    {
        public AuditLog[] Scan()
        {
            Type type = typeof(UserActions);
            MethodInfo[] methods = type.GetMethods();
            AuditLog[] logs = new AuditLog[methods.Length];
            int index = 0;

            foreach (MethodInfo method in methods)
            {
                object[] attrs = method.GetCustomAttributes(typeof(AuditTrailAttribute), false);

                if (attrs.Length > 0)
                {
                    AuditTrailAttribute attr = (AuditTrailAttribute)attrs[0];
                    logs[index++] = new AuditLog
                    {
                        Action = attr.Action,
                        Method = method.Name,
                        Timestamp = DateTime.Now.ToString()
                    };
                }
            }
            return logs;
        }
    }
}
