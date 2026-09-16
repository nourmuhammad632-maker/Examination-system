using Examination_system.Classes.ContentExam;
using Examination_system.Classes.TypeQuestion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.Classes.TypeExam
{
    internal class PracticalExam : Exam

    {
        public PracticalExam(int time, int numberofQuestion, Subject? subject) : base(time, numberofQuestion, subject)
        {
        }
        public void CreateQuestion()
        {
            for (int i = 0; i < NumberofQuestion; i++)
            {
                Console.Clear();
                Console.WriteLine($"==== Practical MCQ Question {i + 1} ====");


                Questions[i] = new MCQQuestion();
                Questions[i].CreateQuestion();
            }

        }

        public override void DisplayResults(int obtainedScore, int totalMarks)
        {
            Console.Clear();
            Console.WriteLine("Practical Exam Results:");
            for (int i = 0; i < Questions.Length; i++)
            {
                Question q = Questions[i];
                Console.WriteLine($"Question {i + 1}: {q.Body}");
                Console.WriteLine($"Your Answer => {q.UserAnswer?.AnswerText}");
                Console.WriteLine($"Correct Answer => {q.RightAnswer?.AnswerText}\n");
            }

            Console.WriteLine($"Your Grade is {obtainedScore} from {totalMarks}");
        }
    }
    }

