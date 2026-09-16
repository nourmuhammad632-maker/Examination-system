using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.Classes.ContentExam
{
    internal class Answers
    {
        public Answers(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public int AnswerId {  get; set; }
        public string? AnswerText {  get; set; }

        public override string ToString() => $"{AnswerId} & {AnswerText}";

    }
}
