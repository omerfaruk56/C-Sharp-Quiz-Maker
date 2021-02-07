using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker.views
{
    class Director
    {
        public void Construct(IExamMakerBuilder builder)
        {
            builder.examName();
            builder.examLocationid();
            builder.supervisorid();
            builder.groupid();
            builder.questionMakerid();
           
        }
    }
}
