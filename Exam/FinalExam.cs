using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class FinalExam : Exam
    {
        public override TypesOfExam TypesOfExam { get; set; } = TypesOfExam.FinalExam;


        public FinalExam(int time, int numberOfQuestions) : base(time,numberOfQuestions)
        {
            Answers = new Answers[NumberOfQuestions];
        }


        public override void ShowExam()
        {
            base.ShowExam();
            ShowExamResult();
        }
        public void ShowExamResult()
        {
            Console.Clear();
            Console.WriteLine("--The Right Answers Of The Exam--");
            int Grade = 0;

            for (int i = 0; i < Questions?.Length; i++)
            {
                if (Questions[i].GetType().Name == "McqQuestion")
                {
                    string answer = "";
                    string[] Array = Questions[i].RightAnswer.AnswerText.Split(',');
                    for (int j = 0; j < Array?.Length; j++)
                    {
                        if (Array[j] == Questions[i].Answers[j].AnswerText)
                        {
                            answer += Questions[i].Answers[j].AnswerText + " ";
                        }
                    }
                    Console.WriteLine($"Question {i + 1} - {Questions[i].QuestionBody} --> The Right Answer : {answer}");
                }
                else
                {
                    Console.WriteLine($"Question {i + 1} - {Questions[i].QuestionBody} --> The Right Answer :  {Questions[i].RightAnswer.AnswerText}");
                }

                if (Answers[i].AnswerText == Questions[i].RightAnswer.AnswerText)
                {
                    Grade += Questions[i].Mark;
                }
            }
            Console.WriteLine($"Your Grade is : {Grade} From {ExamGrade} ");
        }
    }
}
