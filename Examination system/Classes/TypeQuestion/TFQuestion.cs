using Examination_system.Classes.ContentExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.Classes.TypeQuestion
{
    internal class TFQuestion : Question
    {
        public TFQuestion():base("TRue /False", "", 0, new Answers[2],new Answers (1,""))
        {
        }

        public TFQuestion(string header, string body, int mark, Answers[] answerList, Answers rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
           if (answerList == null || answerList?.Length != 2)
            {
                throw new ArgumentNullException("True&False Question Must have exactly 2 answer");

            }

        }
        private static Answers[] GetDefaultTFAnswers()
        {
            return new Answers[2]
            {
                new Answers(1, "True"),
                new Answers(2, "False")
            };
        }

        public override void CreateQuestion()
        {
            Console.Write("Enter Question Body: ");
             Body = Console.ReadLine() ?? "";
            
            

            Console.Write(" Please Enter Question Mark: ");
            int mark;
            while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
            {
                Console.WriteLine("Invalid Mark ,Enter a positive number : ");

            }
            Mark= mark;

            AnswerList = GetDefaultTFAnswers();

            

            Console.Write("Enter Right Answer ID (1for true -2 for false): ");
            int rightAnswerId;
            while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 2)
            {

                Console.WriteLine("Ivaliid choice.Enter A number from 1 OR 2");

            }

            RightAnswer = AnswerList[rightAnswerId - 1];
        }
    }
}
