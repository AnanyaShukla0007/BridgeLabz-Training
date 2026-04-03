using System;

class Course
{
    public string CourseName;
    public int Duration;
}

class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;
}

class PaidOnlineCourse : OnlineCourse
{
    public int Fee;
    public int Discount;
}

class Program
{
    static void Main()
    {
        PaidOnlineCourse c = new PaidOnlineCourse();
        c.CourseName = "C#";
        c.Platform = "Udemy";
        c.Fee = 5000;

        Console.WriteLine(c.CourseName + " " + c.Fee);
    }
}
