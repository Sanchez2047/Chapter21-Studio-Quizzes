using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public abstract class Question
    {
        public static int QuestionNum { get; set; }
        public string QuestionAsked { get; set; }
        public string CorrectAnswer { get; set; }
        public static double TotalPossPoints { get; set; }
        public static double NumCorrect { get; set; }
        public static double NumIncorrect { get; set; }
        public abstract void PrintQuestion();
        public abstract void CheckAnswers();

        public Question(string question, string correctAsnwer)
        {
            this.QuestionAsked = question;
            this.CorrectAnswer = correctAsnwer;
            QuestionNum++;
        }
        public Question()
        { }

    }
}
