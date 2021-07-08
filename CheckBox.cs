using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public class CheckBox : Question
    {
        public Dictionary<char, string> PossAnswerDict = new Dictionary<char, string>()
        {
            {'A',""},
            {'B',""},
            {'C',""},
            {'D',""}
        };
        public string[] PossAnswers { get; set; }
        public string[] CorrectAnswers { get; set; }
        public char[] UserAnswers { get; set; }
        public char UserInput { get; set; }

        private int _questionNum { get; }


        public override void PrintQuestion()
        {
            Console.WriteLine($"{_questionNum}_______{QuestionAsked}(Please list all that apply seperated by comma)");
            foreach (KeyValuePair<char, string> answer in PossAnswerDict)
            {
                Console.WriteLine($"\t{answer.Key}. {answer.Value}");
            }
            string str = Console.ReadLine().ToUpper();
            str.Replace(" ", "");
            string newstr = str.Replace(",", "");
            UserAnswers = newstr.ToCharArray();
            CheckAnswers();
        }
        public override void CheckAnswers()
        {
            foreach(char letter in UserAnswers)
            {
                if (!CorrectAnswer.Contains(PossAnswerDict[letter]))
                {
                    NumIncorrect++;
                    Console.WriteLine("InCorrect!");
                    break;
                }
                else
                {
                    NumCorrect++;
                    Console.WriteLine("Correct!");
                }
            }
        }

        public CheckBox(string question, string correctAnswer, string[] possAnswers) : base(question, correctAnswer)
        {
            this.QuestionAsked = question;
            this.CorrectAnswer = correctAnswer;
            string newAnswer = CorrectAnswer.ToUpper();
            newAnswer.Replace(" ", "");
            CorrectAnswers = newAnswer.Split(",");
            char letter = 'A';
            foreach (string answer in possAnswers)
            {
                PossAnswerDict[letter] = answer;
                int numLetter = letter + 1;
                letter = (char)numLetter;
            }
            this._questionNum = QuestionNum;
            Quiz.Add(this);
        }
    }
}
