using System;
using System.Collections.Generic;

namespace SmartCheckout
{
    internal sealed class CheckoutUtility
    {
        private Queue<Customer> customerQueue = new Queue<Customer>();
        private Dictionary<string, Item> inventory = new Dictionary<string, Item>();

        public CheckoutUtility()
        {
            inventory["Milk"] = new Item(50, 10);
            inventory["Bread"] = new Item(30, 5);
            inventory["Eggs"] = new Item(10, 20);
        }

        // ADD CUSTOMER
        public void AddCustomer()
        {
            Console.Write("Customer Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Number of items: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> items = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Item " + (i + 1) + ": ");
                items.Add(Console.ReadLine()!);
            }

            customerQueue.Enqueue(new Customer(name, items));
            Console.WriteLine("Customer added to queue.");
        }

        // PROCESS CUSTOMER
        public void ProcessCustomer()
        {
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("No customers in queue.");
                return;
            }

            Customer customer = customerQueue.Dequeue();
            int total = 0;

            Console.WriteLine("Billing for " + customer.GetName());

            foreach (string itemName in customer.GetItems())
            {
                if (inventory.ContainsKey(itemName))
                {
                    Item item = inventory[itemName];
                    if (item.ReduceStock())
                    {
                        total += item.GetPrice();
                        Console.WriteLine(itemName + " - ₹" + item.GetPrice());
                    }
                    else
                    {
                        Console.WriteLine(itemName + " - Out of stock");
                    }
                }
                else
                {
                    Console.WriteLine(itemName + " - Not available");
                }
            }

            Console.WriteLine("Total Bill: ₹" + total);
        }

        public void ShowQueueStatus()
        {
            Console.WriteLine("Customers waiting: " + customerQueue.Count);
        }
    }
}
