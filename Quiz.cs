using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    public class Quiz
    {

        public static List<MultipleChoice> mcQuestions = new List<MultipleChoice>();
        public static List<CheckBox> cbQuestions = new List<CheckBox>();
        public static void AddMC(MultipleChoice question)
        {
            mcQuestions.Add(question);
        }
        public static void AddCB(CheckBox question)
        {
            cbQuestions.Add(question);
        }

        public static void PrintAll()
        {
            foreach (MultipleChoice question in mcQuestions)
            {
                question.PrintQuestion();
            }
            foreach (CheckBox question in cbQuestions)
            {
                question.PrintQuestion();
            }
        }
    }
}
