using System;

// Base product class
abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

// Product categories
class Book : Product { }
class Clothing : Product { }

class Marketplace
{
    // Generic method with constraint
    public void ApplyDiscount<T>(T product, double percentage) where T : Product
    {
        product.Price -= product.Price * (percentage / 100);
        Console.WriteLine($"{product.Name} New Price: {product.Price}");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book { Name = "C# Guide", Price = 500 };
        Marketplace market = new Marketplace();

        market.ApplyDiscount(book, 10);
    }
}
