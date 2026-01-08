using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.SmartHomeAutomation.Models
{
    internal class Light : Appliance
    {
        public Light(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine("Light is turned ON with soft brightness.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Light is turned OFF.");
        }
    }
}