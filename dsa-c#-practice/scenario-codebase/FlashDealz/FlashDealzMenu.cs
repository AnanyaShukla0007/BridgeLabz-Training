using System;

namespace FlashDealz
{
    internal class FlashDealzMenu
    {
        public void Start()
        {
            Product[] products =
            {
                new Product("Phone", 30),
                new Product("Shoes", 50),
                new Product("Laptop", 40),
                new Product("Watch", 70)
            };

            IProductSorter sorter = new QuickSortUtility();
            sorter.Sort(products);

            Console.WriteLine("Top Discounted Products:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.GetName() + " - " + p.GetDiscount() + "%");
            }
        }
    }
}
