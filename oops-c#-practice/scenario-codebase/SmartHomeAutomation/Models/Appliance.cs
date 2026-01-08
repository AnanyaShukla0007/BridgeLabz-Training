using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraning.SmartHomeAutomation.Interfaces;

namespace BridgeLabzTraning.SmartHomeAutomation.Models
{
    internal abstract class Appliance : IControllable
    {
        public string Name { get; protected set; }

        protected Appliance(string name)
        {
            Name = name;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
