using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public enum TypesOfExam
    {
      FinalExam = 1,
      practicalExam = 2 
    }
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Answers[] Answers { get; set; }
        public int ExamGrade { get; set; }
        public abstract TypesOfExam TypesOfExam { get; set; }


        public Exam(int time, int numberOfQuestions)
        {
           this.TimeOfExam = time;
           this.NumberOfQuestions = numberOfQuestions;
           this.Questions = new Question[numberOfQuestions];
           this.Answers = new Answers[numberOfQuestions];
        }

        public virtual void ShowExam()
        {
            for (int i = 0; i < Questions?.Length; i++)
            {
                Answers[i] = new Answers();
                Console.WriteLine(Questions[i]);
                Console.WriteLine("---------------------------");
                int id;
                string answer = "";
                if (Questions[i].GetType().Name == "McqQuestion")
                {
                    do
                    {
                        Console.WriteLine("Enter Your Answer : ");
                        answer = Console.ReadLine();
                    } 
                    while (!(answer is string));
                    Answers[i].AnswerText = answer;
                }
                else
                {
                    do { }
                    while (!int.TryParse(Console.ReadLine(), out id));

                    Answers[i].AnswerId = id;

                    for (int j = 0; j < Questions[i].Answers?.Length; j++)
                    {
                        if (Questions[i].Answers[j].AnswerId == id)
                        { 
                            Answers[i].AnswerText = Questions[i].Answers[j].AnswerText;
                        }
                    }
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("------------------------------------");

            }
        }




       
    }
}
