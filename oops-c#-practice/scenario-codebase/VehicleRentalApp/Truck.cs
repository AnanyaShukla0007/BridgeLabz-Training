using System;
using System.ComponentModel.Design.Serialization;
// Truck class derived from vehicle
public class Truck : Vehicle, IRentable{
    // Initialize truck with number and rate
    public Truck(string num,double rate){
        // Calling base class constructor
        VehicleNumber=num;
        cost=rate;
    }

    // Calculate rent for days
    public double CalculateRent(int day){
        return cost*day;
    }
}