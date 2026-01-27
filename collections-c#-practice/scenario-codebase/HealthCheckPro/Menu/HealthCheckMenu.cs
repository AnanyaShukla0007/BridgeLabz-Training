using HealthCheckPro.Services;
using HealthCheckPro.Utilities;

namespace HealthCheckPro.Menu
{
    internal class HealthCheckMenu
    {
        public void Start()
        {
            ApiScannerService scanner = new ApiScannerService();
            DocumentationGenerator generator = new DocumentationGenerator();

            generator.Generate(scanner.Scan());
        }
    }
}
