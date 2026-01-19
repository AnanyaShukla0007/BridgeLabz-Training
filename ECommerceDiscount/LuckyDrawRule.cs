using System;

namespace ECommerceDiscount
{
    sealed class LuckyDrawRule : IDiscountRule
    {
        public int Priority
        {
            get { return 3; }
        }

        public double Apply(double amount)
        {
            Console.WriteLine("Enter Lucky Draw Number:");
            string input = Console.ReadLine();

            int num = Convert.ToInt32(input);

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Lucky Draw Won! Get 15% off on your bill.");
                return amount * 0.85;
            }
            else
            {
                Console.WriteLine("Better luck next time");
                return amount;
            }
        }
    }
}
