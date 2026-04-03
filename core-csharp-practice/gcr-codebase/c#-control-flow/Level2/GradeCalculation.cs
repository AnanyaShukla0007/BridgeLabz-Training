using System;
class GradeCalculation
{
    static void Main()
    {
        Console.Write("Enter Physics marks: ");
        double physics = double.Parse(Console.ReadLine());
        Console.Write("Enter Chemistry marks: ");
        double chemistry = double.Parse(Console.ReadLine());
        Console.Write("Enter Maths marks: ");
        double maths = double.Parse(Console.ReadLine());
        double average = (physics + chemistry + maths) / 3;
        string grade, remarks;
        if (average >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (average >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (average >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching agency-normalized standards";
        }
        else if (average >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (average >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }
        Console.WriteLine("\nAverage Marks: " + average);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}
