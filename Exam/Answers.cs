﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Answers 
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        //public bool IsCorrect { 
        //         get
        //      {
        //        if (IsCorrect == true)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //      }
        //}


        public Answers() { }
        public Answers(string answerText, int answerId)
        {
            this.AnswerText = answerText;
            this.AnswerId = answerId;
        }


    }
}
