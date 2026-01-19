using System;
using System.Collections.Generic;

namespace ExamProctor
{
    internal sealed class ExamUtility
    {
        private Stack<int> navigation = new Stack<int>();
        private Dictionary<int, string> answers = new Dictionary<int, string>();

        public void VisitQuestion()
        {
            Console.Write("Question ID: ");
            int qid = Convert.ToInt32(Console.ReadLine());
            navigation.Push(qid);
        }

        public void AnswerQuestion()
        {
            Console.Write("Question ID: ");
            int qid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Answer: ");
            string ans = Console.ReadLine()!;

            answers[qid] = ans;
        }

        public void SubmitExam()
        {
            int score = CalculateScore();
            Console.WriteLine("Final Score: " + score);
        }

        private int CalculateScore()
        {
            int score = 0;

            foreach (var entry in answers)
            {
                if (entry.Value == "A") // assume correct answer = A
                    score++;
            }
            return score;
        }
    }
}
