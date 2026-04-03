using System;
using EventTracker.Models;

namespace EventTracker.Utilities
{
    internal class JsonLogFormatter
    {
        public void Print(AuditLog[] logs)
        {
            Console.WriteLine("Audit Logs:");

            foreach (AuditLog log in logs)
            {
                if (log == null) continue;

                Console.WriteLine(
                    "{ \"action\": \"" + log.Action +
                    "\", \"method\": \"" + log.Method +
                    "\", \"timestamp\": \"" + log.Timestamp + "\" }"
                );
            }
        }
    }
}
