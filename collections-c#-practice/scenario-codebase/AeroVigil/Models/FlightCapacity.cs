namespace AeroVigil.Models
{
    internal class FlightCapacity
    {
        public int MaxPassengers;
        public double FuelTankCapacity;

        public FlightCapacity(int passengers, double fuel)
        {
            MaxPassengers = passengers;
            FuelTankCapacity = fuel;
        }
    }
}
