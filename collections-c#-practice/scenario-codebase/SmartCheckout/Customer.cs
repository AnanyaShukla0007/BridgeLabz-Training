using System.Collections.Generic;

namespace SmartCheckout
{
    internal class Customer
    {
        private string name;
        private List<string> items;

        public Customer(string name, List<string> items)
        {
            this.name = name;
            this.items = items;
        }

        public string GetName()
        {
            return name;
        }

        public List<string> GetItems()
        {
            return items;
        }
    }
}
