using System;

namespace BridgeLabzTraning.DSA
{
    internal class FurnitureCutting
    {
        static void FurnitureCuts(int[] price, int length)
        {
            // 🔹 Scenario A: Best revenue
            int maxRevenue = price[length - 1];
            int bestCut = length;

            for (int i = 1; i < length; i++)
            {
                int revenue = price[i - 1] + price[length - i - 1];
                if (revenue > maxRevenue)
                {
                    maxRevenue = revenue;
                    bestCut = i;
                }
            }

            Console.WriteLine("Scenario A - Max Revenue: " + maxRevenue);

            // 🔹 Scenario B: Waste constraint (max waste = 2 ft)
            int maxWaste = 2;
            int revenueWithWaste = 0;

            for (int cut = length - maxWaste; cut <= length; cut++)
            {
                revenueWithWaste = Math.Max(revenueWithWaste, price[cut - 1]);
            }

            Console.WriteLine("Scenario B - Revenue with Waste Constraint: "
                + revenueWithWaste);

            // 🔹 Scenario C: Max revenue + minimum waste
            int waste = length - bestCut;

            Console.WriteLine("Scenario C - Best Cut Length: " + bestCut);
            Console.WriteLine("Scenario C - Waste: " + waste);
        }

        static void Main(string[] args)
        {
            int[] price = { 2, 5, 7, 8, 10, 13, 17, 17, 20, 24, 30, 32 };
            int rodLength = 12;

            FurnitureCuts(price, rodLength);

            Console.ReadLine();
        }
    }
}
