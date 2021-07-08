using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public class TrueFalse : Question
    {

        public override void PrintQuestion()
        {

        }
        public override void CheckAnswers()
        {

        }

        public TrueFalse(string question, string correctAnswer) : base(question, correctAnswer)
        {
            this.QuestionAsked = question;
            this.CorrectAnswer = correctAnswer;
        }
    }
}
