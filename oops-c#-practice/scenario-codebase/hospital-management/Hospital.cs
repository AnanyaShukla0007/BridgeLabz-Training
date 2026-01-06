using System;
class Hospital
{
    public static void Main()
    {
        // Creating an InPatient object
        InPatient inPatient = new InPatient
        {
            PatientId = 101,
            Name = "Kriss",
            Age = 85,
            NumberOfDays = 50,
            DailyCharge = 200
        };

        // Polymorphism
        inPatient.DisplayInfo();

        // Billing using abstraction
        Bill bill = new Bill(inPatient);
        bill.DisplayBill();

        Console.WriteLine("--------------------");

        // Creating an OutPatient object
        OutPatient outPatient = new OutPatient
        {
            PatientId = 102,
            Name = "Karneast",
            Age = 01,
            ConsultationFee = 5000
        };

        // Polymorphism
        outPatient.DisplayInfo();

        // Billing using abstraction
        Bill bill1 = new Bill(outPatient);
        bill1.DisplayBill();
    }
}
