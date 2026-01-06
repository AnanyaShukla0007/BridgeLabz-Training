// Base class Patient
public class Patient
{
    // Encapsulation using properties
    public int PatientId
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
    public int Age
    {
        get; set;
    }

    // Virtual method for polymorphism
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}
