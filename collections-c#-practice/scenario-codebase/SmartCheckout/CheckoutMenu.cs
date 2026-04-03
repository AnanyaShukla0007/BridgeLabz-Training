using System;

namespace SmartCheckout
{
    internal class CheckoutMenu
    {
        private CheckoutUtility utility = new CheckoutUtility();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Add Customer  2.Process Customer  3.Queue Status  4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddCustomer();
                        break;
                    case 2:
                        utility.ProcessCustomer();
                        break;
                    case 3:
                        utility.ShowQueueStatus();
                        break;
                }
            } while (choice != 4);
        }
    }
}
