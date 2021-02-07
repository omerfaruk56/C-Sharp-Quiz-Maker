using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.views
{
    interface IExamMakerBuilder
    {
        void examName();
        void examLocationid();
        void supervisorid();
        void questionMakerid();
        void groupid();


    }
}
