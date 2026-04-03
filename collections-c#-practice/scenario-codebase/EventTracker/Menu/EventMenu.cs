using EventTracker.Services;
using EventTracker.Utilities;

namespace EventTracker.Menu
{
    internal class EventMenu
    {
        public void Start()
        {
            AuditScannerService scanner = new AuditScannerService();
            JsonLogFormatter formatter = new JsonLogFormatter();

            formatter.Print(scanner.Scan());
        }
    }
}
