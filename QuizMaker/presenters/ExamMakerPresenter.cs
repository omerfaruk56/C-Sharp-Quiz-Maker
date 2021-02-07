using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.presenters;
using QuizMaker.views;
using QuizMaker.Views;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace QuizMaker.Presenters
{
    public class ExamMakerPresenter
    {
        IExamMakerView view;
        quizMakerdbEntities dbContext;


        public ExamMakerPresenter(IExamMakerView view)
        {
            this.view = view;
            dbContext = new quizMakerdbEntities();
        }

        public void saveGrid(GridControl grid)
        {
            var yeniQuery = (from e in dbContext.ExamMaker
                             join m in dbContext.QuestionMaker on e.questionMakerid equals m.questionMakerid
                             join s in dbContext.Subject on m.subjectid equals s.subjectid
                             join l in dbContext.Lesson on s.lessonid equals l.lessonid
                             join g in dbContext.Group on e.groupid equals g.groupid
                             join ex in dbContext.ExamLocation on e.examLocationid equals ex.examLocationid
                             join su in dbContext.Supervisor on e.supervisorid equals su.supervisorid
                             select new
                             {
                                 SinavID = e.examMakerid,
                                 Sinav_Adi = e.examName,
                                 Ders = l.lesson1,
                                 Konu = s.subject1,
                                 Soru = m.question,
                                 Grup = g.groupNo,
                                 Derslik = ex.examLocation1,
                                 Gözetmen = su.supervisor1,
                                 l.lessonid,
                                 ex.examLocationid,
                                 su.supervisorid,
                                 m.questionMakerid,
                                 g.groupid

                             }).ToList();
            grid.DataSource = null;
            grid.RefreshDataSource();
            grid.DataSource = yeniQuery;
            grid.Refresh();
        }

        public void load()
        {
            view.saveExamMakerGrid(dbContext.ExamMaker.ToList());
        }

        public void lessonLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "lesson1";
            cmb.ValueMember = "lessonid";
            cmb.DataSource = dbContext.Lesson.ToList();
        }

        public void supervisorLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "supervisor1";
            cmb.ValueMember = "supervisorid";
            cmb.DataSource = dbContext.Supervisor.ToList();
        }

        public void examLocationLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "examLocation1";
            cmb.ValueMember = "examLocationid";
            cmb.DataSource = dbContext.ExamLocation.ToList();
        }

        public void groupLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "groupNo";
            cmb.ValueMember = "groupid";
            cmb.DataSource = dbContext.Group.ToList();
        }

        public void questionLoad(ComboBox cmb, int _lessonid)
        {
            dbContext = new quizMakerdbEntities();
            var query = from q in dbContext.QuestionMaker
                        join s in dbContext.Subject on q.subjectid equals s.subjectid
                        join l in dbContext.Lesson on s.lessonid equals l.lessonid
                        where s.lessonid == _lessonid
                        select new { q.question, q.questionMakerid };
            cmb.DisplayMember = "question";
            cmb.ValueMember = "questionMakerid";
            cmb.DataSource = query.ToList();
        }

        public void examSave(string _examName, int _lessonid, int _examLocationid, int _supervisorid, int _questionMakerid, int _groupid)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new ExamMaker
                {
                    examName = _examName,
                    lessonid = _lessonid,
                    examLocationid = _examLocationid,
                    supervisorid = _supervisorid,
                    questionMakerid = _questionMakerid,
                    groupid = _groupid
                };

                db.ExamMaker.Add(qns);
                db.SaveChanges();
            }

            view.saveExamMakerGrid(dbContext.ExamMaker.ToList());
        }

        public void examUpdate(int _id, string _examName, int _lessonid, int _locationid, int _supervisorid, int _qnsid, int _groupid)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.ExamMaker.Find(_id);
                column.examName = _examName;
                column.lessonid = _lessonid;
                column.examLocationid = _locationid;
                column.supervisorid = _supervisorid;
                column.questionMakerid = _qnsid;
                column.groupid = _groupid;
                context.SaveChanges();
            }
        }

        public void examDelete(int _examid)
        {
            var examMaker = new ExamMaker()
            {
                examMakerid = _examid
            };

            using (var context = new quizMakerdbEntities())
            {
                context.Entry(examMaker).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public int qnstotalScore(string _examName)
        {
            var query = from q in dbContext.ExamMaker
                        join m in dbContext.QuestionMaker on q.questionMakerid equals m.questionMakerid
                        join g in dbContext.Group on q.groupid equals g.groupid
                        where q.examName == _examName && g.groupid == 1
                        select m.questionScore;
            return Convert.ToInt32(query.Sum());

        }

        public string scoreWarning(int _enterScore, string _examName)
        {
            if (qnstotalScore(_examName) < _enterScore)
                return "Sınav İstediğiniz puandan KÜÇÜKTÜR !";
            else if (qnstotalScore(_examName) > _enterScore)
                return "Sınav İstediğiniz puandan BÜYÜKTÜR !";
            else if (qnstotalScore(_examName) == _enterScore)
                return "Sınavın puanı istediğiniz değerdedir !";

            return "sonuç yok";
        }

        public void qnsScoreUpdate(int _setScore, string _examName)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = from q in context.QuestionMaker
                             join e in context.ExamMaker on q.questionMakerid equals e.questionMakerid
                             where e.examName == _examName
                             select q;

                foreach (var i in column)
                {
                    i.questionScore = _setScore;
                }
                context.SaveChanges();
            }
        }

        public void difficultExamMaker(string _examName, int _lessonid, int _examLocationid, int _supervisorid, int _questionMakerid, int _groupid, int soruSayisi)
        {
            double fiftyPercent = (soruSayisi * Math.Floor(0.5));
            double twentyPercent = (soruSayisi * Math.Floor(0.2));
            double thirtyPercent = (soruSayisi * Math.Floor(0.3));

            using (var context = new quizMakerdbEntities())
            {
                var query = (from q in dbContext.QuestionMaker
                             join e in dbContext.ExamMaker on q.questionMakerid equals e.questionMakerid
                             join s in dbContext.Subject on q.subjectid equals s.subjectid
                             join l in dbContext.Lesson on s.lessonid equals l.lessonid
                             where q.questionTypeid == 3
                             select q).Take((int)fiftyPercent);

                var qns = new ExamMaker
                {
                    examName = _examName,
                    lessonid = _lessonid,
                    examLocationid = _examLocationid,
                    supervisorid = _supervisorid,
                    questionMakerid = _questionMakerid,
                    groupid = _groupid
                };

                context.ExamMaker.Add(qns);
                context.SaveChanges();
            }
        }
    }
}