using System;

namespace ExamProctor
{
    internal class ExamMenu
    {
        private ExamUtility utility = new ExamUtility();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Visit Question 2.Answer 3.Submit 4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: utility.VisitQuestion(); break;
                    case 2: utility.AnswerQuestion(); break;
                    case 3: utility.SubmitExam(); break;
                }
            } while (choice != 4);
        }
    }
}
