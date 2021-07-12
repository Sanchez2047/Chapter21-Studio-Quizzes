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
            Question num1 = new MultipleChoice("This is my first question.", "two", new string[] { "one", "two", "three", "four" });
            Question num2 = new MultipleChoice("This is my second question.", "one", new string[] { "one", "two", "three", "four" });
            Question num3 = new MultipleChoice("This is my third question.", "two", new string[] { "one", "two", "three", "four" });
            Question num4 = new MultipleChoice("This is my fourth question.", "three", new string[] { "one", "two", "three", "four" });
            Question num5 = new MultipleChoice("This is my fifth question.", "two", new string[] { "one", "two", "three", "four" });
            Question num6 = new MultipleChoice("This is my sixth question.", "one", new string[] { "one", "two", "three", "four" });
            Question num7 = new MultipleChoice("This is my seventh question.", "four", new string[] { "one", "two", "three", "four" });
            Question num8 = new CheckBox("This is my eight question.", "one", new string[] { "one", "two", "three", "four" });
            Question num9 = new CheckBox("This is my nine question.", "one,two,three,four", new string[] { "one", "two", "three", "four" });
            Question num10 = new CheckBox("This is my tenth question.", "two,three,four", new string[] { "one", "two", "three", "four" });
            Question num11 = new TrueFalse("This is my eleventh question.", "true");
            Question num12 = new TrueFalse("This is my twelfth question.", "false");
            Question num13 = new TrueFalse("This is my thirteenth question.", "true");
            Question num14 = new TrueFalse("This is my fourteenth question.", "false");
            Question num15 = new TrueFalse("This is my fifteenth question.", "false");
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
