using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.FitTrack
{
    internal abstract class Workout
    {
        public string Name { get; set; }
        public int Duration { get; set; } // minutes

        public Workout(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public abstract void ShowDetails();
    }
}
