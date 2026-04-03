using System;

// Interface for reservable items
interface IReservable
{
    void ReserveItem(string borrower);
    bool CheckAvailability();
}

// Abstract LibraryItem
abstract class LibraryItem
{
    private int itemId;
    private string title;
    private string author;

    public void SetItemId(int id) { itemId = id; }
    public int GetItemId() { return itemId; }

    public void SetTitle(string t) { title = t; }
    public string GetTitle() { return title; }

    public void SetAuthor(string a) { author = a; }
    public string GetAuthor() { return author; }

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + GetItemId());
        Console.WriteLine("Title: " + GetTitle());
        Console.WriteLine("Author: " + GetAuthor());
    }

    public abstract int GetLoanDuration(); // in days
}

// Book class
class Book : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public override int GetLoanDuration()
    {
        return 14;
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            Console.WriteLine(borrower + " reserved the book.");
            isAvailable = false;
        }
        else
        {
            Console.WriteLine("Book not available for reservation.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Magazine class
class Magazine : LibraryItem
{
    public override int GetLoanDuration()
    {
        return 7;
    }
}

// DVD class
class DVD : LibraryItem, IReservable
{
    private bool isAvailable = true;

    public override int GetLoanDuration()
    {
        return 3;
    }

    public void ReserveItem(string borrower)
    {
        if (isAvailable)
        {
            Console.WriteLine(borrower + " reserved the DVD.");
            isAvailable = false;
        }
        else
        {
            Console.WriteLine("DVD not available for reservation.");
        }
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}

// Main program
class ProgramLibrary
{
    static void Main()
    {
        Book book = new Book();
        book.SetItemId(1);
        book.SetTitle("C# Basics");
        book.SetAuthor("Rahul");

        Magazine mag = new Magazine();
        mag.SetItemId(2);
        mag.SetTitle("Science Monthly");
        mag.SetAuthor("Anita");

        DVD dvd = new DVD();
        dvd.SetItemId(3);
        dvd.SetTitle("Learning C# Video");
        dvd.SetAuthor("Zainab");

        Console.WriteLine("Book Details:");
        book.GetItemDetails();
        Console.WriteLine("Loan Duration: " + book.GetLoanDuration() + " days");
        book.ReserveItem("Rahul");
        Console.WriteLine("Available? " + book.CheckAvailability());
        Console.WriteLine();

        Console.WriteLine("Magazine Details:");
        mag.GetItemDetails();
        Console.WriteLine("Loan Duration: " + mag.GetLoanDuration() + " days");
        Console.WriteLine();

        Console.WriteLine("DVD Details:");
        dvd.GetItemDetails();
        Console.WriteLine("Loan Duration: " + dvd.GetLoanDuration() + " days");
        dvd.ReserveItem("Anita");
        Console.WriteLine("Available? " + dvd.CheckAvailability());
    }
}
