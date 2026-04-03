using System;
using HealthClinicApp.Core.Roles;

namespace HealthClinicApp.Attributes
{
    /// <summary>
    /// Attribute used to restrict a method or class
    /// to a specific user role (Patient / Receptionist).
    /// 
    /// Enforced using reflection at runtime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class RequiresRoleAttribute : Attribute
    {
        public UserRole RequiredRole { get; }

        public RequiresRoleAttribute(UserRole role)
        {
              this.RequiredRole=role;
        }
    }
}
