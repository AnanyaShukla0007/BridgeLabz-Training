// InPatient inherits Patient + implements IPayable
public class InPatient : Patient, IPayable
{
    // Additional property
    public int NumberOfDays
    {
        get; set;
    }
    public double DailyCharge
    {
        get; set;
    }

    // Overriding  (Polymorphism)
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: In-Patient");
        Console.WriteLine("Days Admitted: " + NumberOfDays);
    }

    // Implementing interface method
    public double CalculateBill()
    {
        return NumberOfDays * DailyCharge;
    }
}
