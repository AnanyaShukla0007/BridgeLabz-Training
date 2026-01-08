public class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name) { }

    public void Fly()
    {
        System.Console.WriteLine($"{Name} glides over the sea.");
    }

    public void Swim()
    {
        System.Console.WriteLine($"{Name} swims near the shore.");
    }

    public override void Display()
    {
        System.Console.WriteLine("Bird: Seagull");
    }
}
