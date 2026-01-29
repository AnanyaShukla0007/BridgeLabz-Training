using System.Collections.Generic;
using OceanFleet.Models;

namespace OceanFleet.Utilities
{
    public class VesselUtil
    {
        private List<Vessel> vesselList = new List<Vessel>();

        public List<Vessel> VesselList
        {
            get { return vesselList; }
            set { vesselList = value; }
        }

        // Requirement 1
        public void addVesselPerformance(Vessel vessel)
        {
            vesselList.Add(vessel);
        }

        // Requirement 2
        public Vessel getVesselById(string vesselId)
        {
            for (int i = 0; i < vesselList.Count; i++)
            {
                if (vesselList[i].vesselId == vesselId) // case-sensitive
                {
                    return vesselList[i];
                }
            }
            return null;
        }

        // Requirement 3
        public List<Vessel> getHighPerformanceVessels()
        {
            List<Vessel> result = new List<Vessel>();

            if (vesselList.Count == 0)
                return result;

            double maxSpeed = vesselList[0].averageSpeed;

            for (int i = 1; i < vesselList.Count; i++)
            {
                if (vesselList[i].averageSpeed > maxSpeed)
                {
                    maxSpeed = vesselList[i].averageSpeed;
                }
            }

            for (int i = 0; i < vesselList.Count; i++)
            {
                if (vesselList[i].averageSpeed == maxSpeed)
                {
                    result.Add(vesselList[i]);
                }
            }

            return result;
        }
    }
}
