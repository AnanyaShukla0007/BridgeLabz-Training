using System;

namespace HealthClinicApp.Utilities
{
    /// <summary>
    /// Handles formatted console output (slips).
    /// </summary>
    public static class ConsolePrinter
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("========================================");
        }

        public static void PrintTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine(title.ToUpper());
            PrintSeparator();
        }

        public static void PrintLine(string label, object value)
        {
            Console.WriteLine($"{label,-15}: {value}");
        }
    }
}
