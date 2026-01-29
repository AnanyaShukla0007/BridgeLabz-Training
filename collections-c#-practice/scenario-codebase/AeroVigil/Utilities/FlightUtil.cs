using System.Collections.Generic;
using AeroVigil.Exceptions;
using AeroVigil.Models;

namespace AeroVigil.Utilities
{
    internal class FlightUtil
    {
        private Dictionary<string, FlightCapacity> flightData =
            new Dictionary<string, FlightCapacity>()
            {
                { "SpiceJet", new FlightCapacity(396, 200000) },
                { "Vistara", new FlightCapacity(615, 300000) },
                { "IndiGo", new FlightCapacity(230, 250000) },
                { "Air Arabia", new FlightCapacity(130, 150000) }
            };

        public void ValidateFlightNumber(string flightNumber)
        {
            if (flightNumber.StartsWith("FL-"))
            {
                string numPart = flightNumber.Substring(3);
                int num;
                if (int.TryParse(numPart, out num) && num >= 1000 && num <= 9999)
                    return;
            }
            throw new InvalidFlightException("The flight number " + flightNumber + " is invalid");
        }

        public void ValidateFlightName(string flightName)
        {
            if (flightData.ContainsKey(flightName))
                return;

            throw new InvalidFlightException("The flight name " + flightName + " is invalid");
        }

        public void ValidatePassengerCount(int count, string flightName)
        {
            FlightCapacity cap = flightData[flightName];

            if (count > 0 && count <= cap.MaxPassengers)
                return;

            throw new InvalidFlightException(
                "The passenger count " + count + " is invalid for " + flightName);
        }

        public double CalculateFuelToFillTank(string flightName, double currentFuel)
        {
            FlightCapacity cap = flightData[flightName];

            if (currentFuel < 0 || currentFuel > cap.FuelTankCapacity)
                throw new InvalidFlightException("Invalid fuel level for " + flightName);

            return cap.FuelTankCapacity - currentFuel;
        }
    }
}
