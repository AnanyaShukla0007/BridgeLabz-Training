using System;

namespace HealthClinicApp.Menus
{
    /// <summary>
    /// Menu shown to patients only.
    /// Patient can ONLY register and request appointment.
    /// </summary>
    public static class PatientMenu
    {
        public static void ShowWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("=== PATIENT PORTAL ===");
        }

        public static void AskBasicIdentity()
        {
            Console.WriteLine();
            Console.Write("Enter Patient Name: ");
            Console.Write("Enter Date of Birth (dd-MM-yyyy): ");
        }

        public static void AskAppointmentDecision()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to request an appointment?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Choose option: ");
        }

        public static void ShowSpecialtyOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Select the specialty you want to consult:");
            Console.WriteLine("1. General Medicine");
            Console.WriteLine("2. Cardiology");
            Console.WriteLine("3. Dermatology");
            Console.WriteLine("4. Orthopedics");
            Console.Write("Enter choice: ");
        }
    }
}
