using System;
using System.IO;

namespace HealthClinicApp.Utilities.Logging
{
    /// <summary>
    /// Simple file-based logger.
    /// </summary>
    public class FileLogger
    {
        private static readonly string LogFilePath =
            "Data/Logs/logs.txt";

        public void Log(string message)
        {
            var entry =
                $"{DateTime.Now:dd-MM-yyyy HH:mm:ss} | {message}";

            File.AppendAllText(LogFilePath, entry + Environment.NewLine);
        }
    }
}
