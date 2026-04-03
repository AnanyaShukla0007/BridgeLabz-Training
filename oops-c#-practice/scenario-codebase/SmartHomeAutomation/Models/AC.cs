using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.SmartHomeAutomation.Models
{
    internal class AC : Appliance
    {
        public AC(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine("AC is cooling the room to 22°C.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("AC is turned OFF to save power.");
        }
    }
}
