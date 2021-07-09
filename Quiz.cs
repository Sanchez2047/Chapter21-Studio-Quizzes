using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public class Quiz
    {

        public static List<Question> Questions = new List<Question>();
        public static void Add(Question question)
        {
            Questions.Add(question);
        }

        public static void StartQuiz()
        {
            foreach (Question question in Questions)
            {
                question.PrintQuestion();
            }
        }
        public static void GradeQuiz()
        {
            double score =100* (Question.NumCorrect / Question.TotalPossPoints);
            double finalScore = Math.Round(score);
            char finalGrade ='A';
            if(finalScore > 90)
            {
                finalGrade = 'A';
            }
            else if (finalScore > 80 && finalScore < 90)
            {
                finalGrade = 'B';
            }
            else if (finalScore > 70 && finalScore < 80)
            {
                finalGrade = 'C';
            }
            else if (finalScore > 60 && finalScore < 70)
            {
                finalGrade = 'D';
            }
            else if (finalScore < 60)
            {
                finalGrade = 'F';
            }
            Console.WriteLine($"You scored {Question.NumCorrect} out of {Question.TotalPossPoints}\n");
            Console.WriteLine($"Final Grade: {finalGrade} {finalScore}%");
        }


    }
}
