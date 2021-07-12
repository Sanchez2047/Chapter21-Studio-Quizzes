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

            Quiz.StartQuiz();
            Console.WriteLine("\n\n");
            Quiz.GradeQuiz();
            Console.ReadLine();
        
        }
    }
}
