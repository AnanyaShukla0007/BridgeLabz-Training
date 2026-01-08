public class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name) { }

    public void Swim()
    {
        System.Console.WriteLine($"{Name} swims in the pond.");
    }

    public override void Display()
    {
        System.Console.WriteLine("Bird: Duck");
    }
}
