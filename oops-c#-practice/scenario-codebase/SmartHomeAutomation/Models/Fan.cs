using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.SmartHomeAutomation.Models
{
    internal class Fan : Appliance
    {
        public Fan(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine("Fan is spinning at medium speed.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Fan has stopped.");
        }
    }
}
