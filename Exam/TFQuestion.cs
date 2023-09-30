using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class TFQuestion : Question
    {

        public override string QuestionHeader { get; } = "TF Question";

        public TFQuestion (string body = "", int marks = 0) : base(body, marks)
        {
            Answers = new Answers[2];
            Answers[0] = new Answers("True", 1);
            Answers[1] = new Answers("False", 2);
        }


        public override string ToString()
        {
            return $"-----------{QuestionHeader}-----------\n- {QuestionBody}        Marks({Mark})\n" +
                   $"1.{Answers[0].AnswerText}        2.{Answers[1].AnswerText}";
        }
        public static TFQuestion AddTFQuestion()
        {
            TFQuestion tfQquestion = new TFQuestion();
            Console.WriteLine("---------" + tfQquestion.QuestionHeader + "---------");
            Console.WriteLine("Please Enter The Body of Question:");
            tfQquestion.QuestionBody = Console.ReadLine();
            Console.WriteLine("Please Enter The Marks of Question:");
            tfQquestion.Mark = int.Parse(Console.ReadLine());
            tfQquestion.RightAnswer = new Answers();
            int id;
            do
            {
                Console.WriteLine($"Please Enter The Right Answer For This Question (Press 1 for True Answer , Press 2 for False Answer)");
            } 
            while (!int.TryParse(Console.ReadLine(), out id) || id < 1 || id > 2);
            tfQquestion.RightAnswer.AnswerId = id;
            tfQquestion.RightAnswer.AnswerText = tfQquestion[id].AnswerText;

            return tfQquestion;
        }

    }
}
