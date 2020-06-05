using System;
using System.Collections.Generic;
using System.Text;

namespace Class02.QuizApp.Data.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string CorrectAnswer { get; set; }


        public QuizQuestion(string question, string answerA, string answerB, string answerC, string answerD, string correctAnswer)
        {
            Question = question;
            AnswerA = answerA;
            AnswerB = answerB;
            AnswerC = answerC;
            AnswerD = answerD;
            CorrectAnswer = correctAnswer;
        }

    }
}

    
