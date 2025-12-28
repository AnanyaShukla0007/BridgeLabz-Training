using System;
class YoungestTallest
{
    static void Main()
    {
        int amarAge = int.Parse(Console.ReadLine());
        int akbarAge = int.Parse(Console.ReadLine());
        int anthonyAge = int.Parse(Console.ReadLine());
        int amarHt = int.Parse(Console.ReadLine());
        int akbarHt = int.Parse(Console.ReadLine());
        int anthonyHt = int.Parse(Console.ReadLine());
        int youngest = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        int tallest = Math.Max(amarHt, Math.Max(akbarHt, anthonyHt));
        Console.WriteLine("Youngest Age: " + youngest);
        Console.WriteLine("Tallest Height: " + tallest);
    }
}
