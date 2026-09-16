using Examination_system.Classes.ContentExam;
using Examination_system.Classes.TypeQuestion;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Examination_system.Classes.TypeExam
{
    internal abstract  class Exam
    {
        public Exam(int time, int numberofQuestion, Subject? subject)
        {
            Time = time;
            NumberofQuestion = numberofQuestion;
            Subject = subject;
            Questions = new Question[numberofQuestion];
        }

        
        

        public  int Time {  get; set; }
        public int NumberofQuestion {  get; set; }
        public Subject? Subject { get; set; }
        public Question[] Questions { get; set; }
        public virtual void ShowExam()
        {
            Console.Clear();
            int totalMarks = 0;
            int obtainedScore = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                Question q = Questions[i];
                totalMarks += q.Mark;

                Console.WriteLine($"Question {i + 1}: {q.Body}");
                Console.WriteLine($"Mark {q.Mark}");

                foreach (Answers ans in q.AnswerList)
                {
                    Console.WriteLine($"{ans.AnswerId}- {ans.AnswerText}");
                }

                Console.Write("Enter your answer ID: ");
                int userChoice;
                while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > q.AnswerList.Length)
                {
                    Console.Write($"Invalid choice! Select a number between 1 and {q.AnswerList.Length}: ");
                }

                q.UserAnswer = q.AnswerList[userChoice - 1];

                if (q.UserAnswer.AnswerId == q.RightAnswer.AnswerId)
                {
                    obtainedScore += q.Mark;
                }

                Console.WriteLine();
            }

            
            DisplayResults(obtainedScore, totalMarks);
        }

        
        public abstract void DisplayResults(int obtainedScore, int totalMarks);
    }


}

