namespace ECommerceDiscount
{
    sealed class VipRule : IDiscountRule
    {
        public int Priority
        {
            get { return 1; }
        }

        public double Apply(double amount)
        {
            return amount * 0.2;
        }
    }
}
