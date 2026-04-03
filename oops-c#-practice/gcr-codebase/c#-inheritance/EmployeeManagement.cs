using System;

class Animal
{
    public string Name;
    public int Age;

    public void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat meows");
    }
}

class Bird : Animal
{
    public void Chirp()
    {
        Console.WriteLine("Bird chirps");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.MakeSound();
        d.Bark();
    }
}
