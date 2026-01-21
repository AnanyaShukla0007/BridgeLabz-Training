namespace SmartCheckout
{
    internal class Item
    {
        private int price;
        private int stock;

        public Item(int price, int stock)
        {
            this.price = price;
            this.stock = stock;
        }

        public int GetPrice()
        {
            return price;
        }

        public bool ReduceStock()
        {
            if (stock > 0)
            {
                stock--;
                return true;
            }
            return false;
        }
    }
}
