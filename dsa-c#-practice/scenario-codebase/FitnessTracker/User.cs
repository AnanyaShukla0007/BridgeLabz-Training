namespace FitnessTracker
{
    internal class User
    {
        private string name;
        private int steps;

        public User(string name, int steps)
        {
            this.name = name;
            this.steps = steps;
        }

        public string GetName() => name;
        public int GetSteps() => steps;
    }
}
