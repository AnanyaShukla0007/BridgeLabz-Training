using System;

// Interface for taxable products
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Abstract Product class
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public void SetProductId(int id) { productId = id; }
    public int GetProductId() { return productId; }

    public void SetName(string n) { name = n; }
    public string GetName() { return name; }

    public void SetPrice(double p) { price = p; }
    public double GetPrice() { return price; }

    // Abstract method for discount
    public abstract double CalculateDiscount();

    // Virtual method to display details
    public virtual void Display()
    {
        Console.WriteLine("Product ID: " + GetProductId());
        Console.WriteLine("Name: " + GetName());
        Console.WriteLine("Price: " + GetPrice());
        Console.WriteLine("Discount: " + CalculateDiscount());
    }
}

// Electronics product
class Electronics : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return 0.1 * GetPrice(); // 10% discount
    }

    public double CalculateTax()
    {
        return 0.18 * GetPrice(); // 18% GST
    }

    public string GetTaxDetails()
    {
        return "GST 18%";
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Tax: " + CalculateTax() + " (" + GetTaxDetails() + ")");
        Console.WriteLine("Final Price: " + (GetPrice() + CalculateTax() - CalculateDiscount()));
    }
}

// Clothing product
class Clothing : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return 0.05 * GetPrice(); // 5% discount
    }

    public double CalculateTax()
    {
        return 0.12 * GetPrice(); // 12% GST
    }

    public string GetTaxDetails()
    {
        return "GST 12%";
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Tax: " + CalculateTax() + " (" + GetTaxDetails() + ")");
        Console.WriteLine("Final Price: " + (GetPrice() + CalculateTax() - CalculateDiscount()));
    }
}

// Groceries product
class Groceries : Product
{
    public override double CalculateDiscount()
    {
        return 0; // no discount
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Final Price: " + GetPrice());
    }
}

// Main program
class Program
{
    static void Main()
    {
        Electronics e = new Electronics();
        e.SetProductId(1);
        e.SetName("Laptop");
        e.SetPrice(50000);

        Clothing c = new Clothing();
        c.SetProductId(2);
        c.SetName("T-Shirt");
        c.SetPrice(1000);

        Groceries g = new Groceries();
        g.SetProductId(3);
        g.SetName("Rice");
        g.SetPrice(200);

        Console.WriteLine("Electronics Product:");
        e.Display();

        Console.WriteLine("Clothing Product:");
        c.Display();

        Console.WriteLine("Grocery Product:");
        g.Display();
    }
}
