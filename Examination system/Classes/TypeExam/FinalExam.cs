using Examination_system.Classes.ContentExam;
using Examination_system.Classes.TypeQuestion;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Examination_system.Classes.TypeExam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberofQuestion, Subject? subject) : base(time, numberofQuestion, subject)
        {
        }


        public void CreateQuestions()
        {
            for (int i = 0; i < NumberofQuestion; i++)
            {
                Console.WriteLine($"--- Final Exam Question {i + 1} ---");
                Console.WriteLine($"Question {i + 1}");
                Console.WriteLine("1.MCQ");
                Console.WriteLine("2.True or False");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1 && choice != 2)
                {
                    Console.WriteLine("Invallid ! Choice must 1 or 2 ");

                }
                if (choice == 1)
                {

                    Questions[i] = new MCQQuestion();

                }
                else if (choice == 2)
                {

                    Questions[i] = new TFQuestion();


                }
                Questions[i].CreateQuestion();

            }
        }

        public override void DisplayResults(int obtainedScore, int totalMarks)
        {
            Console.Clear();
            Console.WriteLine("Final Exam Results:");
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
