using System;

class Vehicle{
  // Protected data members (accessible in derived classes)
  protected string VehicleNumber;
  protected double cost;

  // Constructor to initialize vehicle details
  public Vehicle(string number,double rate){
    VehicleNumber=number;
    cost=rate;
  }

  //display vehicle info
  public void Show(){
    Console.WriteLine("Vehicle Number: " + VehicleNumber);
  }
}
    