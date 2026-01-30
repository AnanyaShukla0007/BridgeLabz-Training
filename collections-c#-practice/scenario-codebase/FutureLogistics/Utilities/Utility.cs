using System;
using FutureLogistics.Models;

namespace FutureLogistics.Utilities
{
    public class Utility
    {
        public GoodsTransport parseDetails(string input)
        {
            string[] parts = input.Split(':');

            string transportId = parts[0];
            string date = parts[1];
            int rating = Convert.ToInt32(parts[2]);
            string type = parts[3];

            if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new BrickTransport(
                    transportId, date, rating,
                    float.Parse(parts[4]),
                    int.Parse(parts[5]),
                    float.Parse(parts[6]));
            }
            else
            {
                return new TimberTransport(
                    transportId, date, rating,
                    float.Parse(parts[4]),
                    float.Parse(parts[5]),
                    parts[6],
                    float.Parse(parts[7]));
            }
        }

        public bool validateTransportId(string transportId)
        {
            if (transportId.Length == 7 &&
                transportId.StartsWith("RTS") &&
                char.IsDigit(transportId[3]) &&
                char.IsDigit(transportId[4]) &&
                char.IsDigit(transportId[5]) &&
                char.IsUpper(transportId[6]))
            {
                return true;
            }

            Console.WriteLine("Transport id " + transportId + " is invalid");
            Console.WriteLine("Please provide a valid record");
            return false;
        }

        public string findObjectType(GoodsTransport gt)
        {
            if (gt is TimberTransport) return "TimberTransport";
            if (gt is BrickTransport) return "BrickTransport";
            return "";
        }
    }
}
