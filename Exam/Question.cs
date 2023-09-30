using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public abstract class Question
    {
        //private List<Answers> answers;

        //public int QuestionId { get; set; }
        public abstract String QuestionHeader { get;}
        public String QuestionBody { get; set; }
        public int Mark { get; set; }
        public Answers[] Answers { get; set; }
        public Answers RightAnswer { get; set; }


        public Answers this[int id]
        {
            get
            {
                for (int i = 0; i < Answers?.Length; i++)
                {
                    if (Answers[i].AnswerId == id) return Answers[i];
                }
                return new Answers();
            }
        }
        public Answers this[string text]
        {
            get
            {
                for (int i = 0; i < Answers?.Length; i++)
                {
                    if (Answers[i].AnswerText == text) return Answers[i];
                }
                return new Answers();
            }
        }

       
        public Question(string Body, int marks)
        {
            QuestionBody = Body;
            Mark = marks;
        }


        public static Question[] CreateQuestion (int num)
        {
            Question[] Questions = new Question[num];
            for (int i = 0; i < Questions?.Length; i++)
            {
                int TypeOfQuestion;
                do
                {
                    Console.WriteLine($"Choose The Type Of Question Number {i + 1} (Press 1 For TF Question,Press 2 For MCQ Question)");
                } 
                while (!int.TryParse(Console.ReadLine(), out TypeOfQuestion) || TypeOfQuestion < 1 || TypeOfQuestion > 2);


                if (TypeOfQuestion == 1)
                {
                    Console.WriteLine("-----------------------------");
                    Console.Clear();
                    Console.WriteLine($"Please , Fill The Data OF TF Question Number {i + 1}");
                    Questions[i] = TFQuestion.AddTFQuestion();
                    Console.WriteLine("-----------------------------");
                    Console.Clear();
                }
                else if (TypeOfQuestion == 2)
                {
                    Console.WriteLine("-----------------------------");
                    Console.Clear();
                    Console.WriteLine($"Please , Fill The Data of MCQ Question Number {i + 1}");
                    Questions[i] = McqQuestion.AddMcqQuestion();
                }
            }
            return Questions;
        }




    }
}
