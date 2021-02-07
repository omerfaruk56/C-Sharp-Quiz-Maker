using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizMaker.models;
using QuizMaker.views;
using System.Collections;
using DevExpress.XtraEditors;

namespace QuizMaker.presenters
{
    public class ExamWriterPresenter
    {
        IExamWriterView view;
        quizMakerdbEntities dbContext;
        private int trueCount;
        private int falseCount;
        private int totalScor;
        private int ortalama;
        private int toplam;
        private int min;
        private int max;

        public ExamWriterPresenter(IExamWriterView view)
        {
            this.view = view;
            dbContext = new quizMakerdbEntities();
        }

        public void load()
        {
            view.saveExamWriterGrid(dbContext.ExamWriter.ToList());
        }

        public int answerScore(string _examName, string _grupCode)
        {
            var query = (from m in dbContext.ExamMaker
                         join g in dbContext.Group on m.groupid equals g.groupid
                         join q in dbContext.QuestionMaker on m.questionMakerid equals q.questionMakerid
                         join a in dbContext.Answers on q.answersid equals a.answersid
                         where m.examName == _examName && g.groupNo == _grupCode
                         select q).Take(1);

            foreach (var i in query)
                return (int)i.questionScore;

            return 0;
        }

        public void answerKey(ListBoxControl list, string _examName, string _grupCode)
        {
            var query = from m in dbContext.ExamMaker
                        join g in dbContext.Group on m.groupid equals g.groupid
                        join q in dbContext.QuestionMaker on m.questionMakerid equals q.questionMakerid
                        join a in dbContext.Answers on q.answersid equals a.answersid
                        where m.examName == _examName && g.groupNo == _grupCode
                        select new
                        {
                            a.answers1
                        };

            foreach (var i in query)
            {
                list.Items.Add(i.answers1);

            }
        }

        public string examResult(ListBoxControl listStudentAnswer, ListBoxControl listAnswerKey, string _examName, string _grupCode)
        {
            falseCount = 0;
            trueCount = 0;
            for (int i = 0; i < listStudentAnswer.Items.Count; i++)
            {
                if (listAnswerKey.Items[i].ToString() == listStudentAnswer.Items[i].ToString())
                    trueCount++;
                else
                    falseCount++;
            }
            return "Doğru Sayısı: " + trueCount + " " + "Yanlış Sayısı: " + falseCount + " Puan: " + answerScore(_examName, _grupCode) * trueCount;
        }

        public int totalScore(ListBoxControl _ogrenciPuanList)
        {
            totalScor = 0;
            for (int i = 0; i < _ogrenciPuanList.Items.Count; i++)
            {
                totalScor += int.Parse(_ogrenciPuanList.Items[i].ToString());
            }
            return totalScor;
        }

        public int averageScore(ListBoxControl _klasikSonuc)
        {
            ortalama = 0;
            toplam = 0;

            for (int i = 0; i < _klasikSonuc.Items.Count; i++)
            {
                toplam += int.Parse(_klasikSonuc.Items[i].ToString());
            }
            ortalama = toplam / _klasikSonuc.Items.Count;
            return ortalama;
        }

        public int lowScore(ListBoxControl _klasikSonuc)
        {
            min = 0;
            min = (int)_klasikSonuc.Items[0];

            for (int i = 0; i < _klasikSonuc.Items.Count; i++)
            {
                if (min > (int)_klasikSonuc.Items[i])
                {
                    min = (int)_klasikSonuc.Items[i];
                }
            }
            return min;
        }

        public int highScore(ListBoxControl _klasikSonuc)
        {
            max = 0;
            max = (int)_klasikSonuc.Items[0];

            for (int i = 0; i < _klasikSonuc.Items.Count; i++)
            {
                if (max < (int)_klasikSonuc.Items[i])
                {
                    max = (int)_klasikSonuc.Items[i];
                }
            }
            return max;
        }
    }
}