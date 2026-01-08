public class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        System.Console.WriteLine($"{Name} flies short distances.");
    }

    public override void Display()
    {
        System.Console.WriteLine("Bird: Sparrow");
    }
}
