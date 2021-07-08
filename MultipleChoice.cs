using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public class MultipleChoice : Question
    {
        public Dictionary<char, string> PossAnswerDict = new Dictionary<char, string>()
        {
            {'A',""},
            {'B',""},
            {'C',""},
            {'D',""}
        };
        public char UserInput { get; set; }
        private int _questionNum { get; }
        public override void PrintQuestion()
        {
            Console.WriteLine($"{_questionNum}_______{QuestionAsked}");
            foreach(KeyValuePair<char,string> answer in PossAnswerDict)
            {
                Console.WriteLine($"\t{answer.Key}. {answer.Value}");
            }
            UserInput = Char.Parse(Console.ReadLine().ToUpper());
            CheckAnswers();
        }

        public override void CheckAnswers()
        {
            if (PossAnswerDict[UserInput] == CorrectAnswer)
            {
                NumCorrect++;
                Console.WriteLine("Correct!");
            }
            else if (PossAnswerDict[UserInput] != CorrectAnswer)
            {
                NumIncorrect++;
                Console.WriteLine("InCorrect!");
            }
        }

        public MultipleChoice(string question, string correctAnswer, string[] possAnswers) : base(question,correctAnswer)
        {
            this.QuestionAsked = question;
            this.CorrectAnswer = correctAnswer;
            char letter = 'A';
            foreach(string answer in possAnswers)
            {
                PossAnswerDict[letter] = answer;
                int numLetter = letter+1;
                letter = (char)numLetter;
            }
            this._questionNum = QuestionNum;
            Quiz.Add(this);
        }
    }
}
