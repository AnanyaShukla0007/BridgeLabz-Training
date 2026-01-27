using EventTracker.Attributes;

namespace EventTracker.Actions
{
    internal class UserActions
    {
        [AuditTrail("Login")]
        public void Login() { }

        [AuditTrail("Upload")]
        public void UploadFile() { }

        public void ViewDashboard() { }
    }
}
