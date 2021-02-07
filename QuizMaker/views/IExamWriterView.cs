using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.views;

namespace QuizMaker.views
{
    public interface IExamWriterView
    {

        void saveExamWriterGrid(IList<ExamWriter> liste);

    }
}
