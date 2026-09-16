using Examination_system.Classes.ContentExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.Classes.TypeQuestion
{
    internal abstract class Question
    {




        #region Constructor
        public Question(string header, string body, int mark, Answers[] answerList, Answers rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        } 
        #endregion

        #region Properties
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Answers? UserAnswer { get; set; }
        public override string ToString() => $" {Header}:{Body}";
        #endregion

        #region Abstract Method
        public abstract void CreateQuestion();
        #endregion


    }
}
