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
using QuizMaker.presenters;
using QuizMaker.models;
using QuizMaker.views;

namespace QuizMaker.Views
{
    public partial class DegreeOfDiffForm : XtraForm, IDegreeOfDiffView
    {

        DegreeOffDiffPresenter presenter;

        public DegreeOfDiffForm()
        {
            InitializeComponent();
            presenter = new DegreeOffDiffPresenter();
        }

        private void DegreeOfDiffForm_Load(object sender, EventArgs e)
        {
            load();
        }

        #region Singleton D.P.
        private static DegreeOfDiffForm myform=null;

        public static DegreeOfDiffForm myDegreeOffDiffForm()
        {
            if (myform == null)
                myform = new DegreeOfDiffForm();
            return myform;
        }

        private void DegreeOfDiffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myform = null;
        }

        public void saveSubjectGrid(IList<Subject> liste)
        {
            throw new NotImplementedException();
        }




        #endregion

        #region CRUD


        void load()
        {
            presenter.DegreeOffDiffLoad(cmb_zorlukDerecesi);
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            presenter.degreeOffDiffSave(txt_zorlukDerecesi.Text);
            load();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            presenter.degreeOffDiffUpdate((int)cmb_zorlukDerecesi.SelectedValue, txt_zorlukDerecesi.Text);
            load();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Zorluk Derecesi silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                presenter.degreeOffDiffDelete((int)cmb_zorlukDerecesi.SelectedValue);
                load();
            }
        }

        public void saveDegreeOffDiffGrid(IList<IDegreeOfDiffView> liste)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
