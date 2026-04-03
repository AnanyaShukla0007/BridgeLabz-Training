public class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }

    public void Fly()
    {
        System.Console.WriteLine($"{Name} soars high in the sky.");
    }

    public override void Display()
    {
        System.Console.WriteLine("Bird: Eagle");
    }
}
