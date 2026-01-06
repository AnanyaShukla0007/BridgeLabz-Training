using System;

// Bike class derived from vehicle 
// and implements IRentable
public class Bike : Vehicle,IRentable{
    // Constructor to set bike details
     public Bike(string num,double rate){
        // Calling base class constructor
         VehicleNumber=num;  
         cost=rate;          
     }

    // Calculates total rent for given number of days
     public double CalculateRent(int day){
         return cost*day;
     }
}
      