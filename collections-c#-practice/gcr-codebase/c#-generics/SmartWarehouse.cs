using System;
using System.Collections.Generic;

// Base class for all warehouse items
abstract class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public abstract void Display();
}

// Different item types
class Electronics : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine($"Electronics: {Name}, Qty: {Quantity}");
    }
}

class Groceries : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine($"Grocery: {Name}, Qty: {Quantity}");
    }
}

// Generic storage class with constraint
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayAll()
    {
        foreach (T item in items)
            item.Display();
    }
}

class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics { Name = "Laptop", Quantity = 10 });

        electronicsStorage.DisplayAll();
    }
}
