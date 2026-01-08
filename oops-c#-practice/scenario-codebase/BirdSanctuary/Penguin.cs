public class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) { }

    public void Swim()
    {
        System.Console.WriteLine($"{Name} swims swiftly in cold water.");
    }

    public override void Display()
    {
        System.Console.WriteLine("Bird: Penguin");
    }
}
