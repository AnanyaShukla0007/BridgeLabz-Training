using System;

namespace BridgeLabzTraning.TrafficManager
{
    internal sealed class TrafficUtility : ITrafficActions
    {
        // Circular Linked List head
        private Vehicle? head = null;

        // Queue for waiting vehicles
        private string[] queue = new string[5];
        private int rear = -1, qCount = 0;

        // ================= ADD VEHICLE =================
        public void AddVehicle()
        {
            Console.Write("Vehicle Number: ");
            string num = Console.ReadLine()!;

            // 🔒 Validation added
            if (!IsValidVehicleNumber(num))
            {
                Console.WriteLine("Invalid vehicle number format.");
                return;
            }

            Vehicle newNode = new Vehicle(num);

            if (head == null)
            {
                head = newNode;
                head.Next = head;
                Console.WriteLine("Vehicle added successfully.");
                return;
            }

            Vehicle temp = head;
            while (temp.Next != head)
                temp = temp.Next!;

            temp.Next = newNode;
            newNode.Next = head;

            Console.WriteLine("Vehicle added successfully.");
        }

        // ================= REMOVE VEHICLE =================
        public void RemoveVehicle()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty.");
                return;
            }

            if (head.Next == head)
            {
                head = null;
                Console.WriteLine("Vehicle removed from roundabout.");
                return;
            }

            Vehicle temp = head;
            while (temp.Next!.Next != head)
                temp = temp.Next;

            temp.Next = head.Next;
            head = head.Next;

            Console.WriteLine("Vehicle removed from roundabout.");
        }

        // ================= DISPLAY =================
        public void DisplayRoundabout()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty.");
                return;
            }

            Vehicle temp = head;
            do
            {
                Console.Write(temp.GetNumber() + " -> ");
                temp = temp.Next!;
            } while (temp != head);

            Console.WriteLine("(back to start)");
        }

        // ================= QUEUE =================
        public void AddToWaitingQueue()
        {
            if (qCount == queue.Length)
            {
                Console.WriteLine("Queue Overflow!");
                return;
            }

            Console.Write("Vehicle Number: ");
            string num = Console.ReadLine()!;

            if (!IsValidVehicleNumber(num))
            {
                Console.WriteLine("Invalid vehicle number format.");
                return;
            }

            queue[++rear] = num;
            qCount++;

            Console.WriteLine("Vehicle added to waiting queue.");
        }

        // ================= VALIDATION =================
        private bool IsValidVehicleNumber(string number)
        {
            if (number.Length < 6)
                return false;

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in number)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasLetter && hasDigit;
        }
    }
}
