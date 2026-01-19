using System;
using System.Collections.Generic;

// Base job role
abstract class JobRole
{
    public string CandidateName { get; set; }
    public abstract void Screen();
}

class SoftwareEngineer : JobRole
{
    public override void Screen()
    {
        Console.WriteLine($"Screening Software Engineer: {CandidateName}");
    }
}

class DataScientist : JobRole
{
    public override void Screen()
    {
        Console.WriteLine($"Screening Data Scientist: {CandidateName}");
    }
}

// Generic resume processor
class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T resume)
    {
        resumes.Add(resume);
    }

    public void ProcessAll()
    {
        foreach (T r in resumes)
            r.Screen();
    }
}

class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        seResumes.AddResume(new SoftwareEngineer { CandidateName = "Ana" });

        seResumes.ProcessAll();
    }
}
