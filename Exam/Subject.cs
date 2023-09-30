using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamOfSubject { get; set; }


        public Subject( int id, string name, Exam examOfSubject)
        {
            this.SubjectId = id;
            this.SubjectName = name;
            this.ExamOfSubject = examOfSubject;
        }

        public Subject(int id, string name) : this(id , name , new PracticalExam(60, 10))
        {

        }


        public void CreateExam()
        {
            int ExamType;
            int Time;
            do
            {
                Console.WriteLine("Please Choose The Type of The Exam (Press 1 For Final , Press 2 For Practical)");
            } 
            while (!int.TryParse(Console.ReadLine(), out ExamType) || ExamType < 1 || ExamType > 2);

            ExamOfSubject.TypesOfExam = (TypesOfExam)ExamType;

            do
            {
                Console.WriteLine("Enter Time of The Exam in Minutes :");
            }
            while (!int.TryParse(Console.ReadLine(), out Time) || Time > 60 );

            ExamOfSubject.TimeOfExam = Time;

            Console.WriteLine("Enter The Number Of The Exam Questions: ");
            int numberofQuestions = int.Parse(Console.ReadLine());
            if (ExamOfSubject.TypesOfExam == TypesOfExam.practicalExam)
            {
                ExamOfSubject = new PracticalExam(Time, numberofQuestions);
                ExamOfSubject.Questions = Question.CreateQuestion(numberofQuestions);
            }
            else
            {
                ExamOfSubject = new FinalExam(Time, numberofQuestions);
                ExamOfSubject.Questions = Question.CreateQuestion(numberofQuestions);
            }

            for (int i = 0; i < ExamOfSubject.Questions?.Length; i++)
            {
                ExamOfSubject.ExamGrade += ExamOfSubject.Questions[i].Mark;
            }
        }
       


    }
}
