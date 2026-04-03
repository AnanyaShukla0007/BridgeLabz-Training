using System;

namespace FutureLogistics.Models
{
    public class BrickTransport : GoodsTransport
    {
        private float brickSize;
        private int brickQuantity;
        private float brickPrice;

        public BrickTransport(string transportId, string transportDate, int transportRating,
                              float brickSize, int brickQuantity, float brickPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.brickSize = brickSize;
            this.brickQuantity = brickQuantity;
            this.brickPrice = brickPrice;
        }

        public float BrickSize { get { return brickSize; } set { brickSize = value; } }
        public int BrickQuantity { get { return brickQuantity; } set { brickQuantity = value; } }
        public float BrickPrice { get { return brickPrice; } set { brickPrice = value; } }

        public override string vehicleSelection()
        {
            if (brickQuantity < 300) return "Truck";
            if (brickQuantity <= 500) return "Lorry";
            return "MonsterLorry";
        }

        public override float calculateTotalCharge()
        {
            float price = brickPrice * brickQuantity;
            float tax = price * 0.3f;

            float discount = 0;
            if (transportRating == 5) discount = price * 0.20f;
            else if (transportRating == 3 || transportRating == 4) discount = price * 0.10f;

            float vehicleCost = GetVehicleCost(vehicleSelection());

            return (price + vehicleCost + tax) - discount;
        }

        private float GetVehicleCost(string vehicle)
        {
            if (vehicle.Equals("Truck", StringComparison.OrdinalIgnoreCase)) return 1000;
            if (vehicle.Equals("Lorry", StringComparison.OrdinalIgnoreCase)) return 1700;
            return 3000;
        }
    }
}
