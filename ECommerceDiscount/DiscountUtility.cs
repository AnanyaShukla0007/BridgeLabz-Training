namespace ECommerceDiscount
{
    static class DiscountUtility
    {
        public static double Process(double amount, IDiscountRule[] rules)
        {
            for (int p = 1; p <= 3; p++)
            {
                for (int i = 0; i < rules.Length; i++)
                {
                    if (rules[i].Priority == p)
                    {
                        amount = rules[i].Apply(amount);
                    }
                }
            }
            return amount;
        }
    }
}
