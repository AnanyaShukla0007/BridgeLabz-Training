using System;

namespace ECommerceDiscount
{
    class DiscountMenu
    {
        public static void Start()
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("Enter Bill Amount:");
                double originalAmount = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Are you VIP? (y/n)");
                bool vip = Console.ReadLine().ToLower() == "y";

                Console.WriteLine("First time shopping? (y/n)");
                bool firstTime = Console.ReadLine().ToLower() == "y";

                IDiscountRule[] rules = CreateRules(vip, firstTime);

                double finalAmount = DiscountUtility.Process(originalAmount, rules);

                Console.WriteLine("Original Amount: " + originalAmount);
                Console.WriteLine("Discounted Amount: " + finalAmount);

                Console.WriteLine("1. Continue");
                Console.WriteLine("2. Exit");

                if (Console.ReadLine() == "2")
                {
                    Console.WriteLine("Thanks for shopping with us!");
                    run = false;
                }
            }
        }

        private static IDiscountRule[] CreateRules(bool vip, bool firstTime)
        {
            int count = 1;
            if (vip) count++;
            if (firstTime) count++;

            IDiscountRule[] rules = new IDiscountRule[count];
            int index = 0;

            if (vip)
                rules[index++] = new VipRule();

            if (firstTime)
                rules[index++] = new FirstTimeRule();

            rules[index] = new LuckyDrawRule();
            return rules;
        }
    }
}
