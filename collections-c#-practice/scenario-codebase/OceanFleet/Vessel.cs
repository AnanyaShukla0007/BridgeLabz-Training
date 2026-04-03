namespace OceanFleet.Models
{
    public class Vessel
    {
        public string vesselId { get; set; }
        public string vesselName { get; set; }
        public double averageSpeed { get; set; }
        public string vesselType { get; set; }

        // No-argument constructor
        public Vessel() { }

        // Four-argument constructor
        public Vessel(string vesselId, string vesselName,
                      double averageSpeed, string vesselType)
        {
            this.vesselId = vesselId;
            this.vesselName = vesselName;
            this.averageSpeed = averageSpeed;
            this.vesselType = vesselType;
        }
    }
}
