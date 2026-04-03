using System;
class Program{
    public static void Main(string[] args){
        int choice;
        // Main menu loop
        do{
            Console.WriteLine("Vehicle Rental System");
            Console.WriteLine("1. Rent Bike");
            Console.WriteLine("2. Rent Car");
            Console.WriteLine("3. Rent Truck");
            Console.WriteLine("4. Exit");

            choice=Convert.ToInt32(Console.ReadLine());

            // If renting a vehicle
            if(choice>=1 && choice <= 3) {
                // Get customer details 
                Console.Write("Enter Customer Name: ");
                string name=Console.ReadLine();

                Console.Write("Enter Vehicle Number: ");
                string vno=Console.ReadLine();

                Console.Write("Enter Rate Per Day: ");
                double rate=Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Days: ");
                int day=Convert.ToInt32(Console.ReadLine());

                Customer c=new Customer(name); // create customer
                IRentable rent=null;

                // Select vehicle type
                if (choice == 1){
                    rent=new Bike(vno,rate);
                }else if (choice == 2){
                    rent=new Car(vno,rate);
                }else if (choice == 3){
                    rent=new Truck(vno,rate);
                }
                c.ShowCustomer(); // show customer
                Console.WriteLine("Total Rent: " + rent.CalculateRent(day)); // show rent
            }
        }while(choice!=4);
        Console.WriteLine("Thank You"); // exit message
    }
}