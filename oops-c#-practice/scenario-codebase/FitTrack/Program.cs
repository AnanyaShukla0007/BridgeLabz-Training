using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraning.FitTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserProfile user = new UserProfile("Ana");
            user.DisplayUser();

            Workout[] workouts =
            {
                new CardioWorkout("Running", 30),
                new StrengthWorkout("Weight Training", 45)
            };

            foreach (Workout workout in workouts)
            {
                workout.ShowDetails();

                if (workout is ITrackable trackable)
                {
                    trackable.Track();
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
