using System;
using AeroVigil.Utilities;
using AeroVigil.Exceptions;

namespace AeroVigil.Menu
{
    internal class UserInterface
    {
        public void Start()
        {
            Console.WriteLine("Enter flight details");
            string input = Console.ReadLine();

            string[] parts = input.Split(':');

            if (parts.Length != 4)
            {
                Console.WriteLine("Invalid input format");
                return;
            }

            string flightNumber = parts[0];
            string flightName = parts[1];

            int passengerCount;
            double fuelLevel;

            if (!int.TryParse(parts[2], out passengerCount) ||
                !double.TryParse(parts[3], out fuelLevel))
            {
                Console.WriteLine("Passenger count or fuel level is invalid");
                return;
            }

            FlightUtil util = new FlightUtil();

            try
            {
                util.ValidateFlightNumber(flightNumber);
                util.ValidateFlightName(flightName);
                util.ValidatePassengerCount(passengerCount, flightName);

                double fuelNeeded =
                    util.CalculateFuelToFillTank(flightName, fuelLevel);

                Console.WriteLine("Fuel required to fill the tank: " +
                                  fuelNeeded + " liters");
            }
            catch (InvalidFlightException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
