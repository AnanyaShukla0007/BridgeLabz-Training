namespace ECommerceDiscount
{
    sealed class FirstTimeRule : IDiscountRule
    {
        public int Priority
        {
            get { return 2; }
        }

        public double Apply(double amount)
        {
            return amount * 0.1;
        }
    }
}
