using System;
public class Bill
{
    // Reference of interface (abstraction)
    private IPayable payable;

    // Constructor
    public Bill(IPayable payable)
    {
        this.payable = payable;
    }

    // Display bill amount
    public void DisplayBill()
    {
        Console.WriteLine("Total Bill Amount: " + payable.CalculateBill());
    }
}
