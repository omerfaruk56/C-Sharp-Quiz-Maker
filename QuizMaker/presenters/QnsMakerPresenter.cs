using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.Views;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace QuizMaker.Presenters
{
    public class QnsMakerPresenter
    {
        private int ansid;
        private int choiceid;
        IQnsMakerView view;
        quizMakerdbEntities dbContext;

        public QnsMakerPresenter(IQnsMakerView view)
        {
            this.view = view;
            dbContext = new quizMakerdbEntities();

        }

        public void questionSave(string _question, int _subjectid, int _questionTypeid, int _degreeOffDiffid, int _questionScore, int _answerid, int _mChoiceOptionid)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new QuestionMaker
                {
                    question = _question,
                    subjectid = _subjectid,
                    questionTypeid = _questionTypeid,
                    degreeOfDifficultid = _degreeOffDiffid,
                    questionScore = _questionScore,
                    answersid = _answerid,
                    mChoiceOptionid = _mChoiceOptionid
                };

                db.QuestionMaker.Add(qns);
                db.SaveChanges();
            }

            view.saveQnsMakerGrid(dbContext.QuestionMaker.ToList());
        }

        public void questionUpdate(int id, string _question, int _subjectid, int _questionTypeid, int _degreeOffDiffid, int _questionScore)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.QuestionMaker.Find(id);
                column.question = _question;
                column.subjectid = _subjectid;
                column.questionTypeid = _questionTypeid;
                column.degreeOfDifficultid = _degreeOffDiffid;
                column.questionScore = _questionScore;
                context.SaveChanges();
            }
        }

        public void questionDelete(int qnsid)
        {
            var qnsMaker = new QuestionMaker()
            {
                questionMakerid = qnsid
            };

            using (var context = new quizMakerdbEntities())
            {
                context.Entry(qnsMaker).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void answerUpdate(int id, string _answer)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.Answers.Find(id);
                column.answers1 = _answer;
                context.SaveChanges();
            }
        }

        public void choiceUpdate(int id, string _a, string _b, string _c, string _d)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.MChoiceOption.Find(id);
                column.A = _a;
                column.B = _b;
                column.C = _c;
                column.D = _d;
                context.SaveChanges();
            }
        }

        public int answerSave(string _answer)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new Answers
                {
                    answers1 = _answer
                };

                db.Answers.Add(qns);
                db.SaveChanges();
            }

            var query = (from a in dbContext.Answers
                         orderby a.answersid descending
                         select a.answersid).Take(1);

            foreach (var item in query)
            {
                ansid = item;
            }
            return ansid;

        }

        public int mChoiceOptionSave(string _a, string _b, string _c, string _d)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new MChoiceOption
                {
                    A = _a,
                    B = _b,
                    C = _c,
                    D = _d
                };

                db.MChoiceOption.Add(qns);
                db.SaveChanges();
            }

            var query = (from m in dbContext.MChoiceOption
                         orderby m.mChoiceOptionid descending
                         select m.mChoiceOptionid).Take(1);

            foreach (var item in query)
            {
                choiceid = item;
            }
            return choiceid;

        }

        public void saveGrid(GridControl grid)
        {
            var yeniQuery = (from m in dbContext.QuestionMaker
                             join s in dbContext.Subject on m.subjectid equals s.subjectid
                             join l in dbContext.Lesson on s.lessonid equals l.lessonid
                             join t in dbContext.QuestionType on m.questionTypeid equals t.questionTypeid
                             join d in dbContext.DegreeOfDifficult on m.degreeOfDifficultid equals d.degreeOffDiffid
                             join a in dbContext.Answers on m.answersid equals a.answersid
                             join ch in dbContext.MChoiceOption on m.mChoiceOptionid equals ch.mChoiceOptionid into joined
                             from j in joined.DefaultIfEmpty()
                             select new
                             {
                                 SoruID = m.questionMakerid,
                                 Soru = m.question,
                                 Ders = l.lesson1,
                                 Konu = s.subject1,
                                 Soru_Tipi = t.questionType1,
                                 Zorluk_Derecesi = d.degreeOfDiff,
                                 Puan = m.questionScore,
                                 Cevap = a.answers1,
                                 A_secenegi = j.A,
                                 B_secenegi = j.B,
                                 C_secenegi = j.C,
                                 D_secenegi = j.D,
                                 secimID = m.mChoiceOptionid,
                                 cevapID = a.answersid,
                                 t.questionTypeid,
                                 s.subjectid,
                                 d.degreeOffDiffid,
                                 l.lessonid
                             }).ToList();
            grid.DataSource = null;
            grid.RefreshDataSource();
            grid.DataSource = yeniQuery;
            grid.Refresh();
        }

        public void load()
        {

            view.saveQnsMakerGrid(dbContext.QuestionMaker.ToList());
        }

        public void lessonLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "lesson1";
            cmb.ValueMember = "lessonid";
            cmb.DataSource = dbContext.Lesson.ToList();
        }

        public void subjectLoad(ComboBox cmb, int _lessonid)
        {
            dbContext = new quizMakerdbEntities();
            var query = from id in dbContext.Subject
                        where id.lessonid == _lessonid
                        select id;
            cmb.DisplayMember = "subject1";
            cmb.ValueMember = "subjectid";
            cmb.DataSource = query.ToList();
        }

        public void questionTypeLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "questionType1";
            cmb.ValueMember = "questionTypeid";
            cmb.DataSource = dbContext.QuestionType.ToList();
        }

        public void degreeOffDiffLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "degreeOfDiff";
            cmb.ValueMember = "degreeOffDiffid";
            cmb.DataSource = dbContext.DegreeOfDifficult.ToList();
        }

        public void search(GridControl grid, int _kriterIndex, int _qnsTypeid, int _lessonid, int _subjectid, int _diffid, int _score)
        {
            var yeniQuery = (from m in dbContext.QuestionMaker
                             join s in dbContext.Subject on m.subjectid equals s.subjectid
                             join l in dbContext.Lesson on s.lessonid equals l.lessonid
                             join t in dbContext.QuestionType on m.questionTypeid equals t.questionTypeid
                             join d in dbContext.DegreeOfDifficult on m.degreeOfDifficultid equals d.degreeOffDiffid
                             join a in dbContext.Answers on m.answersid equals a.answersid
                             join ch in dbContext.MChoiceOption on m.mChoiceOptionid equals ch.mChoiceOptionid into joined
                             from j in joined.DefaultIfEmpty()
                             select new
                             {
                                 SoruID = m.questionMakerid,
                                 Soru = m.question,
                                 Ders = l.lesson1,
                                 Konu = s.subject1,
                                 Soru_Tipi = t.questionType1,
                                 Zorluk_Derecesi = d.degreeOfDiff,
                                 Puan = m.questionScore,
                                 Cevap = a.answers1,
                                 A_secenegi = j.A,
                                 B_secenegi = j.B,
                                 C_secenegi = j.C,
                                 D_secenegi = j.D,
                                 secimID = m.mChoiceOptionid,
                                 cevapID = a.answersid,
                                 t.questionTypeid,
                                 s.subjectid,
                                 d.degreeOffDiffid,
                                 l.lessonid
                             }).ToList();
            grid.DataSource = null;
            grid.RefreshDataSource();

            switch (_kriterIndex)
            {
                case 0:
                    var qnsTypeQuery = from t in yeniQuery
                                       where t.questionTypeid == _qnsTypeid
                                       select t;
                    grid.DataSource = qnsTypeQuery;
                    break;
                case 1:
                    var lessonQuery = from t in yeniQuery
                                      where t.lessonid == _lessonid
                                      select t;
                    grid.DataSource = lessonQuery;
                    break;
                case 2:
                    var subjectQuery = from t in yeniQuery
                                       where t.subjectid == _subjectid
                                       select t;
                    grid.DataSource = subjectQuery;
                    break;
                case 3:
                    var diffQuery = from t in yeniQuery
                                    where t.degreeOffDiffid == _diffid
                                    select t;
                    grid.DataSource = diffQuery;
                    break;
                case 4:
                    var scoreQuery = from t in yeniQuery
                                     where t.Puan == _score
                                     select t;
                    grid.DataSource = scoreQuery;
                    break;

                default:
                    break;
            }
            grid.Refresh();
        }
    }
}