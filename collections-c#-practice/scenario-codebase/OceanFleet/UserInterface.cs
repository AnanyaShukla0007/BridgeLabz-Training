using System;
using OceanFleet.Models;
using OceanFleet.Utilities;
using System.Collections.Generic;

namespace OceanFleet.Menu
{
    public class UserInterface
    {
        public void Start()
        {
            VesselUtil util = new VesselUtil();

            Console.WriteLine("Enter the number of vessels to be added");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter vessel details");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(':');

                Vessel vessel = new Vessel(
                    parts[0],
                    parts[1],
                    Convert.ToDouble(parts[2]),
                    parts[3]
                );

                util.addVesselPerformance(vessel);
            }

            Console.WriteLine("Enter the Vessel Id to check speed");
            string searchId = Console.ReadLine();

            Vessel found = util.getVesselById(searchId);

            if (found != null)
            {
                Console.WriteLine(
                    found.vesselId + " | " +
                    found.vesselName + " | " +
                    found.vesselType + " | " +
                    found.averageSpeed + " knots"
                );
            }
            else
            {
                Console.WriteLine("Vessel Id " + searchId + " not found");
            }

            Console.WriteLine("High performance vessels are");

            List<Vessel> highPerf = util.getHighPerformanceVessels();

            for (int i = 0; i < highPerf.Count; i++)
            {
                Vessel v = highPerf[i];
                Console.WriteLine(
                    v.vesselId + " | " +
                    v.vesselName + " | " +
                    v.vesselType + " | " +
                    v.averageSpeed + " knots"
                );
            }
        }
    }
}
