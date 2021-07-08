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

            //Quiz quiz = new Quiz();


            MultipleChoice num1 = new MultipleChoice("This is my first question", "two", new string[] { "one", "two", "three", "four" });
            MultipleChoice num2 = new MultipleChoice("This is my second question", "one", new string[] { "one", "two", "three", "four" });
            MultipleChoice num3 = new MultipleChoice("This is my third question", "two", new string[] { "one", "two", "three", "four" });
            MultipleChoice num4 = new MultipleChoice("This is my fourth question", "three", new string[] { "one", "two", "three", "four" });
            MultipleChoice num5 = new MultipleChoice("This is my fifth question", "two", new string[] { "one", "two", "three", "four" });
            MultipleChoice num6 = new MultipleChoice("This is my sixth question", "one", new string[] { "one", "two", "three", "four" });
            MultipleChoice num7 = new MultipleChoice("This is my seventh question", "four", new string[] { "one", "two", "three", "four" });
            CheckBox num8 = new CheckBox("This is my eight question", "one,two", new string[] { "one", "two", "three", "four" });
            CheckBox num9 = new CheckBox("This is my nine question", "one,two,three,four", new string[] { "one", "two", "three", "four" });
            CheckBox num10 = new CheckBox("This is my 10 question", "one,two,four", new string[] { "one", "two", "three", "four" });

            Quiz.AddMC(num1);
            Quiz.AddMC(num2);
            Quiz.AddMC(num3);
            Quiz.AddMC(num4);
            Quiz.AddMC(num5);
            Quiz.AddMC(num6);
            Quiz.AddMC(num7);
            Quiz.AddCB(num8);
            Quiz.AddCB(num9);
            Quiz.AddCB(num10);


            Console.WriteLine(Question.NumCorrect);

            Quiz.PrintAll();

            Console.WriteLine(Question.NumCorrect);
            Console.WriteLine(Question.NumIncorrect);



            
            Console.ReadLine();
        }
    }
}
