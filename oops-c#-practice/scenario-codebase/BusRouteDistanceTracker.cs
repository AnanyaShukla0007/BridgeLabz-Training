using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning
{
    internal class BusRouteDistanceTracker
    {
        static void Main()
        {
            int totalDistance = 0;
            string choice = "no";

            while (choice != "yes")
            {
                Console.Write("Enter distance for this stop (in km): ");
                int distance = Convert.ToInt32(Console.ReadLine());

                totalDistance += distance;

                Console.Write("Do you want to get off at this stop? (yes/no): ");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Total distance travelled: " + totalDistance + " km");
        }
    }
}
