using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class McqQuestion : Question
    {
        public override string QuestionHeader { get; } = "MCQ Question";

        public McqQuestion(string body = "", int marks = 0) : base(body,marks)
        {
            Answers = new Answers[3];
        }
        

        public static McqQuestion AddMcqQuestion()
        {
            McqQuestion mcqQuestion = new McqQuestion();
            Console.WriteLine("---------" + mcqQuestion.QuestionHeader + "---------" );
            Console.WriteLine("Please Enter The Body Of Question:");
            mcqQuestion.QuestionBody = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks Of Question:");
            mcqQuestion.Mark = int.Parse(Console.ReadLine());

            for (int i = 0; i < mcqQuestion.Answers?.Length; i++)
            {
                mcqQuestion.Answers[i] = new Answers();
                Console.WriteLine($"Please Enter The Choice Number {i + 1}");
                mcqQuestion.Answers[i].AnswerText = Console.ReadLine();
                mcqQuestion.Answers[i].AnswerId = i + 1;
            }
            mcqQuestion.RightAnswer = new Answers();
            string answer = "";
            do
            {
                Console.WriteLine($"Please Enter The Right Answer For This Question");
                answer = Console.ReadLine();
            } 
            while (!(answer is string));
            mcqQuestion.RightAnswer.AnswerText = answer;
            return mcqQuestion;
        }

        public override string ToString()
        {
            return $"-----------{QuestionHeader}-----------\n- {QuestionBody}        Marks({Mark})\n" +
                   $"1.{Answers[0].AnswerText}          2.{Answers[1].AnswerText}           3.{Answers[2].AnswerText}";
        }






        //public List<String> Choices
        //{
        //    get
        //    {
        //        if (!this.choices.Contains("True") && !this.choices.Contains("False"))
        //        {
        //            Random random = new Random();
        //            this.choices = this.choices.OrderBy(x => random.Next()).ToList();
        //            return this.choices;
        //        }
        //        else
        //        {
        //            return this.choices;
        //        }
        //    }
        //}

       


        

       
    }
}
