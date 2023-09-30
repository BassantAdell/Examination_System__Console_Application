using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region XXXXXXXXXX
            //Exam exam = new Exam();

            //Console.WriteLine(exam.ToString());
            //Console.Write("Your Choice About Exam is : ");
            //string? ex = Console.ReadLine();

            //if (ex != null)
            //{
            //    Console.WriteLine("--------------------------------------");
            //    Question question = new Question();

            //    if (ex == "FINAL".ToLower())
            //    {
            //        FinalExam finalExam = new FinalExam();
            //        Console.WriteLine("You selected Final Exam");

            //        Console.Write("Please, Select The Type Of Question (TF or MCQ): ");
            //        string? questionSelected = Console.ReadLine();

            //        if (questionSelected != null)
            //        {
            //            if (questionSelected == "TF".ToLower())
            //            {
            //                TFQuestion tfQuestion = new TFQuestion();
            //                Console.WriteLine("---" + tfQuestion.ToString() + "---");

            //                Console.WriteLine("Write the Question?");
            //                //question.WriteQuestion();
            //                string tf1 = Console.ReadLine();

            //                Console.WriteLine("Define Number of Marks For This Question :");
            //                string n = Console.ReadLine();

            //                // steps:
            //                //1- add answers (True   False)
            //                //2- select l answer
            //                //3- msh 3arfa
            //            }

            //            if (questionSelected == "MCQ".ToLower())
            //            {
            //                McqQuestion mcqQuestion = new McqQuestion();
            //                Console.WriteLine("---" + mcqQuestion.ToString() + "---");

            //                Console.WriteLine("Write the Question?");
            //                string mcq1 = Console.ReadLine();

            //                Console.WriteLine("Define Number of Marks For This Question :");
            //                string n = Console.ReadLine();

            //                // steps:
            //                //1- add answers (Chooooose   1-    2-   3-)
            //                //2- select l answer
            //                //3- msh 3arfa
            //            }
            //        }
            //    }
            //    else if (ex == "Practical".ToLower())
            //    {
            //        PracticalExam practicalExam = new PracticalExam();
            //        Console.WriteLine("You selected Practical Exam");

            //        TFQuestion tfQuestion = new TFQuestion();
            //        Console.WriteLine("---" + tfQuestion.ToString() + "---");

            //        Console.WriteLine("Write the Question?");
            //        //question.WriteQuestion();
            //        string tf1 = Console.ReadLine();

            //        Console.WriteLine("Define Number of Marks For This Question :");
            //        string n = Console.ReadLine();

            //        // steps:
            //        //1- add answers (True   False)
            //        //2- select l answer
            //        //3- msh 3arfa
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please, Write (Final Or Practical) ");
            //    }
            //}
            #endregion

            Subject subject = new Subject(1 , "C#");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam (y | n): ");
           
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();
                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject.ExamOfSubject.ShowExam();
                SW.Stop();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
                Console.WriteLine("---------------------------------");
            }

        }
    }
}