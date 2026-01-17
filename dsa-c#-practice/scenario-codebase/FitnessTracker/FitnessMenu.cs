using System;

namespace FitnessTracker
{
    internal class FitnessMenu
    {
        public void Start()
        {
            User[] users =
            {
                new User("Ana", 8200),
                new User("Riya", 12000),
                new User("Neha", 9500),
                new User("Amit", 6000)
            };

            IStepSorter sorter = new BubbleSortUtility();
            sorter.Sort(users);

            Console.WriteLine("Daily Step Leaderboard:");
            foreach (User u in users)
            {
                Console.WriteLine(u.GetName() + " - " + u.GetSteps());
            }
        }
    }
}
