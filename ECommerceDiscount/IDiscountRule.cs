namespace ECommerceDiscount
{
    interface IDiscountRule
    {
        int Priority { get; }
        double Apply(double amount);
    }
}
