using HealthCheckPro.Attributes;

namespace HealthCheckPro.Controllers
{
    internal class LabController
    {
        [PublicApi]
        public void GetReports() { }

        [PublicApi, RequiresAuth]
        public void BookTest() { }

        public void InternalCleanup() { }
    }
}
