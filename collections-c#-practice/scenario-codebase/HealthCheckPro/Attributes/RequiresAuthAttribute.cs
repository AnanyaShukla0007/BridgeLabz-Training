using System;

namespace HealthCheckPro.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class RequiresAuthAttribute : Attribute { }
}
