using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.FitTrack
{
    internal class StrengthWorkout : Workout, ITrackable
    {
        public StrengthWorkout(string name, int duration)
            : base(name, duration)
        {
        }

        public void Track()
        {
            Console.WriteLine("Tracking strength workout repetitions.");
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Strength Workout: " + Name + ", Duration: " + Duration + " mins");
        }
    }
}
