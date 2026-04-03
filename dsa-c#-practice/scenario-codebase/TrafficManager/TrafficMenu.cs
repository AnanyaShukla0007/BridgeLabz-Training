using System;

namespace BridgeLabzTraning.TrafficManager
{
    internal class TrafficMenu
    {
        private ITrafficActions traffic;

        public TrafficMenu()
        {
            traffic = new TrafficUtility();
        }

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Add 2.Remove 3.Display 4.Queue 5.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: traffic.AddVehicle(); break;
                    case 2: traffic.RemoveVehicle(); break;
                    case 3: traffic.DisplayRoundabout(); break;
                    case 4: traffic.AddToWaitingQueue(); break;
                }
            } while (choice != 5);
        }
    }
}
