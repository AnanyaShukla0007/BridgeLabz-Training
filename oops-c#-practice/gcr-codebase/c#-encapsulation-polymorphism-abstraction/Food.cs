using System;

// Interface for discountable items
interface IDiscountable
{
    void ApplyDiscount(double percent);
    string GetDiscountDetails();
}

// Abstract class FoodItem
abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public void SetItemName(string name) { itemName = name; }
    public string GetItemName() { return itemName; }

    public void SetPrice(double p) { price = p; }
    public double GetPrice() { return price; }

    public void SetQuantity(int q) { quantity = q; }
    public int GetQuantity() { return quantity; }

    public void GetItemDetails()
    {
        Console.WriteLine("Item Name: " + GetItemName());
        Console.WriteLine("Price: " + GetPrice());
        Console.WriteLine("Quantity: " + GetQuantity());
    }

    public abstract double CalculateTotalPrice();
}

// VegItem class
class VegItem : FoodItem, IDiscountable
{
    private double discount = 0;

    public override double CalculateTotalPrice()
    {
        return (GetPrice() * GetQuantity()) - discount;
    }

    public void ApplyDiscount(double percent)
    {
        discount = (GetPrice() * GetQuantity()) * percent / 100;
    }

    public string GetDiscountDetails()
    {
        return "Veg Discount: " + discount;
    }

    public void Display()
    {
        GetItemDetails();
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
        Console.WriteLine(GetDiscountDetails());
    }
}

// NonVegItem class
class NonVegItem : FoodItem, IDiscountable
{
    private double extraCharge = 50;
    private double discount = 0;

    public override double CalculateTotalPrice()
    {
        return (GetPrice() * GetQuantity()) + extraCharge - discount;
    }

    public void ApplyDiscount(double percent)
    {
        discount = ((GetPrice() * GetQuantity()) + extraCharge) * percent / 100;
    }

    public string GetDiscountDetails()
    {
        return "NonVeg Discount: " + discount;
    }

    public void Display()
    {
        GetItemDetails();
        Console.WriteLine("Extra Charge: " + extraCharge);
        Console.WriteLine("Total Price: " + CalculateTotalPrice());
        Console.WriteLine(GetDiscountDetails());
    }
}

// Main Program
class ProgramFood
{
    static void Main()
    {
        VegItem veg = new VegItem();
        veg.SetItemName("Paneer Butter Masala");
        veg.SetPrice(200);
        veg.SetQuantity(2);
        veg.ApplyDiscount(10);
        Console.WriteLine("Veg Item:");
        veg.Display();
        Console.WriteLine();

        NonVegItem nonveg = new NonVegItem();
        nonveg.SetItemName("Chicken Curry");
        nonveg.SetPrice(250);
        nonveg.SetQuantity(1);
        nonveg.ApplyDiscount(5);
        Console.WriteLine("Non-Veg Item:");
        nonveg.Display();
    }
}
