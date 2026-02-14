using System.Threading.Tasks;

namespace HealthClinicApp.Utilities.Logging
{
    /// <summary>
    /// Asynchronous logger for future multithreading use.
    /// </summary>
    public class AsyncLogger
    {
        private readonly FileLogger _fileLogger = new();

        public Task LogAsync(string message)
        {
            return Task.Run(() => _fileLogger.Log(message));
        }
    }
}
