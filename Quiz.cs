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
        public static List<CheckBox> cbQuestions = new List<CheckBox>();
        public static void Add(Question question)
        {
            Questions.Add(question);
        }

        public static void PrintAll()
        {
            foreach (Question question in Questions)
            {
                question.PrintQuestion();
            }
        }
    }
}
