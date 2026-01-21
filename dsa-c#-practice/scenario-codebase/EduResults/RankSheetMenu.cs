using System;

namespace EduResults
{
    internal class RankSheetMenu
    {
        public void Start()
        {
            // Simulating merged district data
            Student[] students =
            {
                new Student("Ananya", 95, "Mathura"),
                new Student("Ravi", 88, "Agra"),
                new Student("Neha", 95, "Delhi"),
                new Student("Amit", 72, "Noida"),
                new Student("Sonal", 88, "Agra")
            };

            MergeSortUtility sorter = new MergeSortUtility();
            sorter.Sort(students);

            Console.WriteLine("State-wise Rank List:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + students[i].GetInfo());
            }
        }
    }
}
