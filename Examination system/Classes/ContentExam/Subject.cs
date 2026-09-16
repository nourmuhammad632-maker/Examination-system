using Examination_system.Classes.TypeExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system.Classes.ContentExam
{
    internal class Subject
    {
        public int SubjectId {  get; set; }
        public string? SubjectName { get; set; }
        
        public Exam ?SubjectExam {  get; set; }
        public Subject(int subjectId, string? subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public void CreateExam()
        {
           
            Console.Write("Enter Exam Type (1 for Practical, 2 for Final): ");
            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
            {
                Console.WriteLine("Invalid type. Enter 1 for Practical or 2 for Final:");
            }
            Console.WriteLine("Enter the time for exam (30 to 180 minutes) ");
            int time;
            while (!int.TryParse(Console.ReadLine(), out time) || (time <30 ||  time >180))
            {
                Console.Write("Invalid duration. Enter a time between 30 and 180 minutes: ");
            }
            Console.Write("Enter Number of Questions: ");
            int numQuestions;
            while (!int.TryParse(Console.ReadLine(), out numQuestions) || numQuestions <= 0)
                Console.Write("Invalid number. Enter at least 1: ");

            if (examType == 1)
                SubjectExam = new PracticalExam(time, numQuestions,this);
            else
                SubjectExam = new FinalExam(time, numQuestions,this);
            

            
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}, Name: {SubjectName}";
        
    }
        }
    }
