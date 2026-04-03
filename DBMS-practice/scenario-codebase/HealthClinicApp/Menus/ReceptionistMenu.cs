using System;

namespace HealthClinicApp.Menus
{
    /// <summary>
    /// Menu shown to receptionist only.
    /// Access must be password protected.
    /// </summary>
    public static class ReceptionistMenu
    {
        public static void ShowLogin()
        {
            Console.WriteLine();
            Console.WriteLine("=== RECEPTIONIST LOGIN ===");
            Console.WriteLine("Access restricted to authorized staff only.");
            Console.Write("Enter receptionist password: ");
        }

        public static void ShowDashboard()
        {
            Console.WriteLine();
            Console.WriteLine("=== RECEPTIONIST DASHBOARD ===");
            Console.WriteLine("1. View Pending Appointment Requests");
            Console.WriteLine("2. Process Appointment by Patient ID");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
        }

        public static void AskPatientId()
        {
            Console.WriteLine();
            Console.Write("Enter Patient ID (or 0 to go back): ");
        }

        public static void AskVisitCompletion()
        {
            Console.WriteLine();
            Console.WriteLine("Has the patient visited the doctor?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Choose option: ");
        }

        public static void AskPaymentMode()
        {
            Console.WriteLine();
            Console.WriteLine("Select Payment Mode:");
            Console.WriteLine("1. Cash");
            Console.WriteLine("2. UPI");
            Console.WriteLine("3. Card");
            Console.Write("Choose option: ");
        }
    }
}
