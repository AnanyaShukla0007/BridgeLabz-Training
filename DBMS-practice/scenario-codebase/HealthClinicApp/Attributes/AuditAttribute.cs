using System;

namespace HealthClinicApp.Attributes
{
    /// <summary>
    /// Attribute used to mark actions that must be audited.
    /// Audit logging is handled via reflection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AuditAttribute : Attribute
    {
        public string ActionName { get; }

        public AuditAttribute(string actionName)
        {
            ActionName = actionName;
        }
    }
}
