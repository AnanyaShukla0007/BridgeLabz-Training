using System;

namespace EventTracker.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class AuditTrailAttribute : Attribute
    {
        public string Action;

        public AuditTrailAttribute(string action)
        {
            Action = action;
        }
    }
}
