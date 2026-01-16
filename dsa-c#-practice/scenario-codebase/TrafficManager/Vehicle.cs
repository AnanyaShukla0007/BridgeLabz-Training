namespace BridgeLabzTraning.TrafficManager
{
    internal class Vehicle
    {
        private string number;
        public Vehicle? Next;   // 👈 nullable pointer

        public Vehicle(string number)
        {
            this.number = number;
            Next = null;
        }

        public string GetNumber()
        {
            return number;
        }
    }
}
