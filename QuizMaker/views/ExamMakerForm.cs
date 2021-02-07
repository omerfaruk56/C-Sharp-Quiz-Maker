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
using QuizMaker.views;
using QuizMaker.Presenters;

namespace QuizMaker.Views
{
    public partial class ExamMakerForm : XtraForm, IExamMakerView
    {
        ExamMakerPresenter presenter;
        int examid;

        public ExamMakerForm()
        {
            InitializeComponent();
            presenter = new ExamMakerPresenter(this);
        }

        #region Singleton D.P.
        private static ExamMakerForm myExamForm;

        public static ExamMakerForm myExamMakerForm()
        {
            if (myExamForm == null)
                myExamForm = new ExamMakerForm();
            return myExamForm;
        }
        private void ExamMakerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myExamForm = null;

        }


        #endregion

        private void ExamMakerForm_Load(object sender, EventArgs e)
        {
            Director newDirector = new Director();
            IExamMakerBuilder builder = null;
            builder = new ExamMakerBuilder();
            newDirector.Construct(builder);

            load();

            for (int i = 8; i < 13; i++)
                gridView_soruList.Columns[i].Visible = false;
        }

        void load()
        {
            presenter.lessonLoad(cmb_dersSec);
            presenter.examLocationLoad(cmb_derslik);
            presenter.supervisorLoad(cmb_gozetmen);
            presenter.questionLoad(cmb_sorular, (int)cmb_dersSec.SelectedValue);
            presenter.groupLoad(cmb_grupSec);
            presenter.saveGrid(gridControl_sinav);
        }

        public void saveExamMakerGrid(IList<ExamMaker> liste)
        {
            gridControl_sinav.DataSource = null;
            gridControl_sinav.RefreshDataSource();
            gridControl_sinav.DataSource = liste;
            gridControl_sinav.Refresh();
        }

        private void cmb_dersSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.questionLoad(cmb_sorular, (int)cmb_dersSec.SelectedValue);

        }

        private void btn_sinavSorusuEkle_Click(object sender, EventArgs e)
        {
            presenter.examSave(txt_sinavAdi.Text, (int)cmb_dersSec.SelectedValue, (int)cmb_derslik.SelectedValue, (int)cmb_gozetmen.SelectedValue, (int)cmb_sorular.SelectedValue, (int)cmb_grupSec.SelectedValue);
            load();
        }

        private void btn_sinavSorusuGuncelle_Click(object sender, EventArgs e)
        {
            presenter.examUpdate(examid, txt_sinavAdi.Text, (int)cmb_dersSec.SelectedValue, (int)cmb_derslik.SelectedValue, (int)cmb_gozetmen.SelectedValue, (int)cmb_sorular.SelectedValue, (int)cmb_grupSec.SelectedValue);
            load();
        }

        private void btn_SinavSorusuSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Soru silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    presenter.examDelete(examid);
                    load();
                }
            }
            catch
            {

            }
        }

        private void gridView_soruList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            examid = Convert.ToInt32(gridView_soruList.GetFocusedRowCellValue("SinavID"));
            richEditControl_sorular.Text = "";
            txt_SinavAdiArama.Text = txt_sinavAdi.Text;
            txt_sinavAdiArama2.Text = txt_sinavAdi.Text;
            if (gridView_soruList.GetFocusedRowCellValue("Soru") != null)
                richEditControl_sorular.Text = gridView_soruList.GetFocusedRowCellValue("Soru").ToString();
            if (gridView_soruList.GetFocusedRowCellValue("Sinav_Adi") != null)
                txt_sinavAdi.Text = gridView_soruList.GetFocusedRowCellValue("Sinav_Adi").ToString();
            if (gridView_soruList.GetFocusedRowCellValue("lessonid") != null)
                cmb_dersSec.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("lessonid");
            if (gridView_soruList.GetFocusedRowCellValue("examLocationid") != null)
                cmb_derslik.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("examLocationid");
            if (gridView_soruList.GetFocusedRowCellValue("supervisorid") != null)
                cmb_gozetmen.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("supervisorid");
            if (gridView_soruList.GetFocusedRowCellValue("questionMakerid") != null)
                cmb_sorular.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("questionMakerid");
            if (gridView_soruList.GetFocusedRowCellValue("groupid") != null)
                cmb_grupSec.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("groupid");
        }

        private void cmb_sorular_SelectedIndexChanged(object sender, EventArgs e)
        {
            richEditControl_sorular.Text = "";
            richEditControl_sorular.Text = cmb_sorular.Text;
        }

        private void btn_sinavSorusuList_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btn_toplamPuan_Click(object sender, EventArgs e)
        {
            lbl_toplamPuan.Text = "Sonuç: Sınav toplam " + presenter.qnstotalScore(txt_SinavAdiArama.Text).ToString() + " puandan oluşmaktadır.";
            MessageBox.Show(presenter.scoreWarning(int.Parse(txt_puanGir.Text), txt_sinavAdi.Text));
        }

        private void btn_ayarla_Click(object sender, EventArgs e)
        {
            presenter.qnsScoreUpdate(int.Parse(txt_puanAyarla.Text), txt_sinavAdiArama2.Text);
            MessageBox.Show("Sınav Puanı Ayarlama İşlemi Başarılı !");
        }

        private void btn_zorSinav_Click(object sender, EventArgs e)
        {
            presenter.difficultExamMaker(txt_sinavAdi.Text, (int)cmb_dersSec.SelectedValue, (int)cmb_derslik.SelectedValue, (int)cmb_gozetmen.SelectedValue, (int)cmb_sorular.SelectedValue, (int)cmb_grupSec.SelectedValue, int.Parse(textEdit_soruSayisi.Text));
            load();
        }
    }
}