class Program
{
    static void Main()
    {
        Bird[] birds =
        {
            new Eagle("Golden Eagle"),
            new Sparrow("House Sparrow"),
            new Duck("Mallard Duck"),
            new Penguin("Emperor Penguin"),
            new Seagull("White Seagull")
        };

        foreach (Bird bird in birds)
        {
            bird.Display();

            if (bird is IFlyable flyable)
                flyable.Fly();

            if (bird is ISwimmable swimmable)
                swimmable.Swim();

            System.Console.WriteLine();
        }
    }
}
