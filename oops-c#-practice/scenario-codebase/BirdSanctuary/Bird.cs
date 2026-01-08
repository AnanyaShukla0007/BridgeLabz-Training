public abstract class Bird
{
    public string Name { get; set; }

    public Bird(string name)
    {
        Name = name;
    }

    public abstract void Display();
}
