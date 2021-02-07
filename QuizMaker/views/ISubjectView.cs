using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
namespace QuizMaker.views
{
   public interface ISubjectView
    {
        void saveSubjectGrid(IList<Subject> liste);


    }
}
