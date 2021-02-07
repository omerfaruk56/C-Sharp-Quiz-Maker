using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.views;
using QuizMaker.Views;

namespace QuizMaker.Views
{
   public interface IDegreeOfDiffView
    {
        void saveDegreeOffDiffGrid(IList<IDegreeOfDiffView> liste);
    }
}
