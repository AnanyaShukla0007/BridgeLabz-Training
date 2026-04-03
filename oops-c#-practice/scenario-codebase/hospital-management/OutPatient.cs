//inherits Patient and implements IPayable
public class OutPatient : Patient, IPayable
{
    // Additional property
    public double ConsultationFee { get; set; }

    // Overriding  (Polymorphism)
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Patient Type: Out-Patient");
    }

    // Implementing interface method
    public double CalculateBill()
    {
        return ConsultationFee;
    }
}
