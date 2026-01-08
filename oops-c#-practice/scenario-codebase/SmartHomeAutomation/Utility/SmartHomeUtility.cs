using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraning.SmartHomeAutomation.Models;

namespace BridgeLabzTraning.SmartHomeAutomation.Utility
{
    internal class SmartHomeUtility
    {
        private Dictionary<string, List<Appliance>> home;

        public SmartHomeUtility()
        {
            home = new Dictionary<string, List<Appliance>>
            {
                { "Bedroom", new List<Appliance> { new Fan("Fan"), new AC("AC"), new Light("Light") } },
                { "Kitchen", new List<Appliance> { new Light("Light") } },
                { "Bathroom", new List<Appliance> { new Light("Light") } },
                { "Hall", new List<Appliance> { new Fan("Fan"), new Light("Light") } },
                { "Living Room", new List<Appliance> { new Fan("Fan"), new AC("AC"), new Light("Light") } }
            };
        }

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- SMART HOME MENU ---");
                Console.WriteLine("1. List of Rooms");
                Console.WriteLine("2. List of Smart Items");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        RoomFlow();
                        break;
                    case 2:
                        ApplianceFlow();
                        break;
                    case 3:
                        Console.WriteLine("Exiting Smart Home System...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 3);
        }

        // -------- FLOW 1 : Room -> Appliance -> Action --------
        private void RoomFlow()
        {
            string room = SelectOption("Rooms", new List<string>(home.Keys));
            if (room == null) return;

            Appliance appliance = SelectAppliance(home[room]);
            if (appliance == null) return;

            PerformAction(appliance);
        }

        // -------- FLOW 2 : Appliance -> Room -> Action --------
        private void ApplianceFlow()
        {
            List<string> applianceTypes = new List<string> { "Fan", "Light", "AC" };
            string type = SelectOption("Smart Items", applianceTypes);
            if (type == null) return;

            List<string> rooms = new List<string>();
            foreach (var room in home)
            {
                foreach (var app in room.Value)
                {
                    if (app.Name == type)
                        rooms.Add(room.Key);
                }
            }

            string selectedRoom = SelectOption("Available in Rooms", rooms);
            if (selectedRoom == null) return;

            Appliance appliance = home[selectedRoom].Find(a => a.Name == type);
            PerformAction(appliance);
        }

        // -------- COMMON METHODS --------
        private string SelectOption(string title, List<string> options)
        {
            Console.WriteLine($"\n{title}:");
            for (int i = 0; i < options.Count; i++)
                Console.WriteLine($"{i + 1}. {options[i]}");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (choice < 0 || choice >= options.Count)
            {
                Console.WriteLine("Invalid selection!");
                return null;
            }
            return options[choice];
        }

        private Appliance SelectAppliance(List<Appliance> appliances)
        {
            Console.WriteLine("\nSmart Items:");
            for (int i = 0; i < appliances.Count; i++)
                Console.WriteLine($"{i + 1}. {appliances[i].Name}");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (choice < 0 || choice >= appliances.Count)
            {
                Console.WriteLine("Invalid selection!");
                return null;
            }
            return appliances[choice];
        }

        private void PerformAction(Appliance appliance)
        {
            Console.WriteLine("\n1. Turn ON");
            Console.WriteLine("2. Turn OFF");
            Console.Write("Enter choice: ");

            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
                appliance.TurnOn();
            else if (action == 2)
                appliance.TurnOff();
            else
                Console.WriteLine("Invalid action!");
        }
    }
}