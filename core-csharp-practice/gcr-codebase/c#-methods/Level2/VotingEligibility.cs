using System;
class VotingEligibility
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }
    static void Main()
    {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: "); //input
            ages[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote"); //output
        }
    }
}
