using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.Views;
using System.Windows.Forms;

namespace QuizMaker.presenters
{
    public class DegreeOffDiffPresenter
    {
        IDegreeOfDiffView view;
        quizMakerdbEntities dbContext;


        public DegreeOffDiffPresenter()
        {         
            dbContext = new quizMakerdbEntities();
        }

        public void DegreeOffDiffLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "degreeOfDiff";
            cmb.ValueMember = "degreeOffDiffid";
            cmb.DataSource = dbContext.DegreeOfDifficult.ToList();
        }

        public void degreeOffDiffSave(string _degreeOffDiff)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new DegreeOfDifficult
                {
                    degreeOfDiff = _degreeOffDiff
                };

                db.DegreeOfDifficult.Add(qns);
                db.SaveChanges();
            }
        }

        public void degreeOffDiffUpdate(int id,string _degreeOffDiff)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.DegreeOfDifficult.Find(id);
                column.degreeOfDiff = _degreeOffDiff;
                context.SaveChanges();
            }
        }

        public void degreeOffDiffDelete(int id)
        {
            var qnsMaker = new DegreeOfDifficult()
            {
                degreeOffDiffid = id
            };

            using (var context = new quizMakerdbEntities())
            {
                context.Entry(qnsMaker).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
