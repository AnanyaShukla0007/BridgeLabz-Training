using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.FitTrack
{
    internal class CardioWorkout : Workout, ITrackable
    {
        public CardioWorkout(string name, int duration)
            : base(name, duration)
        {
        }

        public void Track()
        {
            Console.WriteLine("Tracking cardio workout calories.");
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Cardio Workout: " + Name + ", Duration: " + Duration + " mins");
        }
    }
}
