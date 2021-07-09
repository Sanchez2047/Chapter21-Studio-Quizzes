using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public class TrueFalse : Question
    {
        public string userAnswer { get; set; }
        private int _questionNum { get; }

        public override void PrintQuestion()
        {
            Console.WriteLine($"{_questionNum}_______(True/False){QuestionAsked}\n");
            userAnswer = Console.ReadLine().ToLower();
            CheckAnswers();
        }
        public override void CheckAnswers()
        {
            if (userAnswer == CorrectAnswer)
            {
                NumCorrect++;
                Console.WriteLine("Correct!\n");
            }
            else
            {
                NumIncorrect++;
                Console.WriteLine("InCorrect!\n");
            }
        }

        public TrueFalse(string question, string correctAnswer) : base(question, correctAnswer)
        {
            this._questionNum = QuestionNum;
            TotalPossPoints++;
            Quiz.Add(this);
        }
    }
}
