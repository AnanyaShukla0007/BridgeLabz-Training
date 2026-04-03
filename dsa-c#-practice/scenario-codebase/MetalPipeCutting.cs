using System;

namespace BridgeLabzTraning.DSA
{
    internal class MetalPipeCutting
    {
        // Try no cut and single cut only
        static int BestRevenue(int[] price, int length)
        {
            int maxRevenue = price[length - 1]; // no cut

            for (int i = 1; i < length; i++)
            {
                int revenue = price[i - 1] + price[length - i - 1];
                if (revenue > maxRevenue)
                {
                    maxRevenue = revenue;
                }
            }
            return maxRevenue;
        }

        static void Main(string[] args)
        {
            // 🔹 Scenario A: Rod length = 8
            int[] priceA = { 1, 5, 8, 9, 10, 17, 17, 20 };
            int lengthA = 8;
            Console.WriteLine("Scenario A - Best Revenue: "
                + BestRevenue(priceA, lengthA));

            // 🔹 Scenario B: Custom length added
            int[] priceB = { 1, 5, 8, 9, 10, 17, 17, 20, 24 };
            int lengthB = 9;
            Console.WriteLine("Scenario B - Revenue with Custom Length: "
                + BestRevenue(priceB, lengthB));

            // 🔹 Scenario C: Non-optimized (no cut)
            Console.WriteLine("Scenario C - Non Optimized Revenue: "
                + priceA[lengthA - 1]);

            Console.ReadLine();
        }
    }
}
