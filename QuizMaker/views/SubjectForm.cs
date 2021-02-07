using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.models;
using QuizMaker.Presenters;
using QuizMaker.views;
namespace QuizMaker.views
{
    public partial class SubjectForm : XtraForm, ISubjectView
    {

        SubjectPresenter presenter;

        public SubjectForm()
        {
            InitializeComponent();
            presenter = new SubjectPresenter();
        }

        public void saveSubjectGrid(IList<Subject> liste)
        {
            throw new NotImplementedException();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            load();
            lessonLoad();
            subjectLoad();
        }

        #region Singleton D.P.
        private static SubjectForm myform=null;

        public static SubjectForm mySubjectForm()
        {
            if (myform == null)
                myform = new SubjectForm();
            return myform;
        }

        private void SubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myform = null;
        }


        #endregion

        #region CRUD
        void load()
        {
            presenter.lessonLoad(cmb_ders1);
        }

        void lessonLoad()
        {
            presenter.lessonLoad(cmb_ders2);
        }

        void subjectLoad()
        {
            presenter.subjectLoad(cmb_konu, (int)cmb_ders2.SelectedValue);
        }

        private void btn_dersEkle_Click(object sender, EventArgs e)
        {
            presenter.lessonSave(txt_ders.Text);
            load();
        }

        private void btn_dersGuncelle_Click(object sender, EventArgs e)
        {
            presenter.lessonUpdate((int)cmb_ders1.SelectedValue, txt_ders.Text);
            load();
        }

        private void btn_dersSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Ders silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                presenter.lessonDelete((int)cmb_ders1.SelectedValue);
                load();
            }
        }

        private void btn_konuEkle_Click(object sender, EventArgs e)
        {
            presenter.subjectSave(txt_konu.Text, (int)cmb_ders2.SelectedValue);
            subjectLoad();
        }

        private void btn_konuGuncelle_Click(object sender, EventArgs e)
        {
            presenter.subjectUpdate((int)cmb_konu.SelectedValue, txt_konu.Text);
            subjectLoad();
        }

        private void btn_konuSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Konu silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                presenter.subjectDelete((int)cmb_konu.SelectedValue);
                subjectLoad();
            }
        }

        private void cmb_ders2_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectLoad();
        }
        #endregion
    }
}
