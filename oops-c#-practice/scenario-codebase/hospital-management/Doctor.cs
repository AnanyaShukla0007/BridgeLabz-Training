// Doctor class
public class Doctor
{
    // Encapsulation 
    public int DoctorId
    {
        get; set;
    }
    public string DoctorName
    {
        get; set;
    }
    public string Specialization
    {
        get; set;
    }

    // Method to display doctor details
    public void DisplayDocInfo()
    {
        Console.WriteLine("Doctor ID: " + DoctorId);
        Console.WriteLine("Doctor Name: " + DoctorName);
        Console.WriteLine("Specialization: " + Specialization);
    }
}
