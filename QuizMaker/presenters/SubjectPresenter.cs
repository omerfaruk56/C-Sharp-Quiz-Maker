using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using System.Windows.Forms;
using QuizMaker.views;

namespace QuizMaker.Presenters
{
    public class SubjectPresenter
    {
        ISubjectView view;
        quizMakerdbEntities dbContext;
     
        public SubjectPresenter()
        {
            
            dbContext = new quizMakerdbEntities();
        }

        public void lessonLoad(ComboBox cmb)
        {
            dbContext = new quizMakerdbEntities();
            cmb.DisplayMember = "lesson1";
            cmb.ValueMember = "lessonid";
            cmb.DataSource = dbContext.Lesson.ToList();
        }

        public void lessonSave(string _lesson)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new Lesson
                {
                    lesson1 = _lesson                                
                };

                db.Lesson.Add(qns);
                db.SaveChanges();
            }

        }
       
        public void lessonUpdate(int id, string _lessson)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.Lesson.Find(id);
                column.lesson1 = _lessson;
                context.SaveChanges();
            }
        }

        public void lessonDelete(int id)
        {      
            var qnsMaker = new Lesson()
            {
                lessonid = id
            };

            using (var context = new quizMakerdbEntities())
            {
                context.Entry(qnsMaker).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
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
        
        public void subjectSave(string _subject,int _lessonid)
        {
            using (var db = new quizMakerdbEntities())
            {
                var qns = new Subject
                {
                    subject1 = _subject,
                    lessonid = _lessonid
                 
                };

                db.Subject.Add(qns);
                db.SaveChanges();
            }
        }

        public void subjectUpdate(int subjectid,string _subject)
        {
            using (var context = new quizMakerdbEntities())
            {
                var column = context.Subject.Find(subjectid);
                column.subject1 = _subject;
                context.SaveChanges();
            }
        }

        public void subjectDelete(int id)
        {
            var qnsMaker = new Subject()
            {
                subjectid = id
            };

            using (var context = new quizMakerdbEntities())
            {
                context.Entry(qnsMaker).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}