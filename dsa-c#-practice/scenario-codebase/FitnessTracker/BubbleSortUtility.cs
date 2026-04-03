namespace FitnessTracker
{
    internal sealed class BubbleSortUtility : IStepSorter
    {
        public void Sort(User[] users)
        {
            int n = users.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (users[j].GetSteps() < users[j + 1].GetSteps())
                    {
                        User temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }
        }
    }
}
