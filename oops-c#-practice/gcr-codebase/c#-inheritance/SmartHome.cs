using System;

class Book
{
    public string Title;
    public int PublicationYear;
}

class Author : Book
{
    public string Name;
    public string Bio;

    public void DisplayInfo()
    {
        Console.WriteLine(Title + " " + PublicationYear + " " + Name);
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author();
        a.Title = "C#";
        a.PublicationYear = 2024;
        a.Name = "Ananya";

        a.DisplayInfo();
    }
}
