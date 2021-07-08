using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Question num1 = new MultipleChoice("This is my first question", "two", new string[] { "one", "two", "three", "four" });
            Question num2 = new MultipleChoice("This is my second question", "one", new string[] { "one", "two", "three", "four" });
            Question num3 = new MultipleChoice("This is my third question", "two", new string[] { "one", "two", "three", "four" });
            Question num4 = new MultipleChoice("This is my fourth question", "three", new string[] { "one", "two", "three", "four" });
            Question num5 = new MultipleChoice("This is my fifth question", "two", new string[] { "one", "two", "three", "four" });
            Question num6 = new MultipleChoice("This is my sixth question", "one", new string[] { "one", "two", "three", "four" });
            Question num7 = new MultipleChoice("This is my seventh question", "four", new string[] { "one", "two", "three", "four" });
            Question num8 = new CheckBox("This is my eight question", "one,two", new string[] { "one", "two", "three", "four" });
            Question num9 = new CheckBox("This is my nine question", "one,two,three,four", new string[] { "one", "two", "three", "four" });
            Question num10 = new CheckBox("This is my 10 question", "one,two,four", new string[] { "one", "two", "three", "four" });

            Console.WriteLine(Question.NumCorrect);

            Quiz.PrintAll();

            Console.WriteLine(Question.NumCorrect);
            Console.WriteLine(Question.NumIncorrect);



            Console.ReadLine();
        }
    }
}
