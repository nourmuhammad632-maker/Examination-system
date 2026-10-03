using Examination_system.Classes.ContentExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.Classes.TypeQuestion
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion()
    : base("MCQ Question", "", 0, new Answers[4], new Answers(1, ""))
        { 
        }

        public MCQQuestion(string header, string body, int mark, Answers[] answerList, Answers rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
            if (answerList == null || answerList.Length != 4)

            {

                throw new ArgumentException(

                "MCQ question must have exactly 4 answers.");

            }

        }

        public override void CreateQuestion()
        {
            Console.Write("Enter Question Body: ");
            Body = Console.ReadLine() ?? "";


           // Console.WriteLine("Please Enter Question Header:");
            //string? inputHeader = Console.ReadLine();
            //Header = string.IsNullOrWhiteSpace(inputHeader) ? "MCQ Question" : inputHeader;

            
            Console.Write("Please Enter Question Mark: ");

            int mark;
            while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
            {
                Console.WriteLine("Invalid Mark ,Enter a positive number : ");
            }
            Mark = mark;

            AnswerList = new Answers[4];
            Console.WriteLine("Choices of Question:");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"Please enter choice number {j + 1}:");

                string? answerText = Console.ReadLine();
                AnswerList[j] = new Answers(j + 1, answerText);

            }
            Console.WriteLine("Enter Right Answer from 1 to 4 ");

            int rightId;
            while (!int.TryParse(Console.ReadLine(), out rightId) || rightId < 1 || rightId > 4)
            {
                Console.Write("Ivaliid choice.Enter A number from 1 to 4");

            }
            RightAnswer = AnswerList[rightId - 1];
        }
    }
}
