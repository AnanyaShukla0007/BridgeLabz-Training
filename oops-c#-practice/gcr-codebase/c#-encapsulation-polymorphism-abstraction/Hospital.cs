using System;

// Interface for medical records
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// Abstract class Patient
abstract class Patient
{
    private int patientId;
    private string name;
    private int age;
    private string record1; // simple single record
    private string record2;

    public void SetPatientId(int id) { patientId = id; }
    public int GetPatientId() { return patientId; }

    public void SetName(string n) { name = n; }
    public string GetName() { return name; }

    public void SetAge(int a) { age = a; }
    public int GetAge() { return age; }

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + GetPatientId());
        Console.WriteLine("Name: " + GetName());
        Console.WriteLine("Age: " + GetAge());
    }

    public abstract double CalculateBill();
}

// InPatient class
class InPatient : Patient, IMedicalRecord
{
    private double roomCharge;
    private double treatmentCharge;
    private string record1;
    private string record2;

    public void SetRoomCharge(double charge) { roomCharge = charge; }
    public void SetTreatmentCharge(double charge) { treatmentCharge = charge; }

    public override double CalculateBill()
    {
        return roomCharge + treatmentCharge;
    }

    public void AddRecord(string record)
    {
        if (record1 == null) record1 = record;
        else record2 = record;
    }

    public void ViewRecords()
    {
        if (record1 != null) Console.WriteLine("Record1: " + record1);
        if (record2 != null) Console.WriteLine("Record2: " + record2);
    }

    public void Display()
    {
        GetPatientDetails();
        Console.WriteLine("Total Bill: " + CalculateBill());
        ViewRecords();
    }
}

// OutPatient class
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private string record1;

    public void SetConsultationFee(double fee) { consultationFee = fee; }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        record1 = record;
    }

    public void ViewRecords()
    {
        if (record1 != null) Console.WriteLine("Record: " + record1);
    }

    public void Display()
    {
        GetPatientDetails();
        Console.WriteLine("Total Bill: " + CalculateBill());
        ViewRecords();
    }
}

// Main Program
class ProgramHospital
{
    static void Main()
    {
        InPatient ip = new InPatient();
        ip.SetPatientId(101);
        ip.SetName("Rahul");
        ip.SetAge(30);
        ip.SetRoomCharge(5000);
        ip.SetTreatmentCharge(2000);
        ip.AddRecord("Blood Test Done");

        OutPatient op = new OutPatient();
        op.SetPatientId(102);
        op.SetName("Anita");
        op.SetAge(25);
        op.SetConsultationFee(500);
        op.AddRecord("General Checkup");

        Console.WriteLine("InPatient Details:");
        ip.Display();
        Console.WriteLine();

        Console.WriteLine("OutPatient Details:");
        op.Display();
    }
}
