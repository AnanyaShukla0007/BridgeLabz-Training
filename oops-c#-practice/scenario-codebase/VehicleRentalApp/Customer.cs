using System;
// Customer class 
public class Customer{
    // Customer name
    public string Name{get;set;}

    // Constructor to set customer name
    public Customer(string name){
        Name=name;
    }

    // Display customer name
    public void ShowCustomer(){
        Console.WriteLine("Customer: " + Name);
    }
}
