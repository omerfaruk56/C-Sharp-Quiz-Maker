using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.presenters;

namespace QuizMaker.views
{
    public class ExamMakerBuilder : IExamMakerBuilder
    {
        ExamMaker e;
        public ExamMakerBuilder()
        {
            e = new ExamMaker();
        }
       
        public void examLocationid()
        {
            e.examLocationid = 1;
        }

        public void examName()
        {
            e.examName = "";
        }

        public void groupid()
        {
            e.groupid = 1;
        }

        public void questionMakerid()
        {
            e.questionMakerid = 1;
        }

        public void supervisorid()
        {
            e.supervisorid = 1;
        }
    }
}
