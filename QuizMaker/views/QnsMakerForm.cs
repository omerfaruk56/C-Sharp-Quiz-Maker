using DevExpress.XtraEditors;
using QuizMaker.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMaker.Presenters;
using QuizMaker.Views;

namespace QuizMaker.Views
{
    public partial class QnsMakerForm : XtraForm, IQnsMakerView
    {

        QnsMakerPresenter presenter;
        int qnsID;
        int ansID;
        int choID;

        public QnsMakerForm()
        {
            InitializeComponent();
            presenter = new QnsMakerPresenter(this);

        }

        #region Singleton D.P.
        private static QnsMakerForm myQnsForm;
        public static QnsMakerForm myQnsMakerForm()
        {
            if (myQnsForm == null)
                myQnsForm = new QnsMakerForm();
            return myQnsForm;
        }

        private void QnsMakerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
              myQnsForm = null;
        }
        #endregion

        private void QnsMakerForm_Load(object sender, EventArgs e)
        {
            load();
            for (int i = 12; i < 18; i++)
                gridView_soruList.Columns[i].Visible = false;
        }

        void load()
        {
            presenter.lessonLoad(cmb_ders);
            presenter.subjectLoad(cmb_konu, (int)cmb_ders.SelectedValue);
            presenter.degreeOffDiffLoad(cmb_zorlukDerecesi);
            presenter.questionTypeLoad(cmb_soruTipi);
            presenter.saveGrid(gridControl_sorular);
        }

        private void btn_soruekle_Click(object sender, EventArgs e)
        {

            presenter.questionSave(richTxt_soru.Text, (int)cmb_konu.SelectedValue, (int)cmb_soruTipi.SelectedValue, (int)cmb_zorlukDerecesi.SelectedValue, int.Parse(cmb_puan.Text), presenter.answerSave(richTxt_cevap.Text), presenter.mChoiceOptionSave(textEdit_ASikki.Text, textEdit_BSikki.Text, textEdit_CSikki.Text, textEdit_DSikki.Text));
            load();
            MessageBox.Show("Ekleme işlemi başarılı !");
        }

        private void btn_sorulariListele_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btn_soruSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek istediğinizden emin misiniz?", "Soru silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                presenter.questionDelete(qnsID);
                load();
            }
        }

        private void btn_soruguncelle_Click(object sender, EventArgs e)
        {
            presenter.questionUpdate(qnsID, richTxt_soru.Text, (int)cmb_konu.SelectedValue, (int)cmb_soruTipi.SelectedValue, (int)cmb_zorlukDerecesi.SelectedValue, int.Parse(cmb_puan.Text));
            presenter.answerUpdate(ansID, richTxt_cevap.Text);
            presenter.choiceUpdate(choID, textEdit_ASikki.Text, textEdit_BSikki.Text, textEdit_CSikki.Text, textEdit_DSikki.Text);
            load();
            MessageBox.Show("Güncelleme işlemi başarılı !");

        }

        private void gridView_soruList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            qnsID = Convert.ToInt32(gridView_soruList.GetFocusedRowCellValue("SoruID"));
            ansID = Convert.ToInt32(gridView_soruList.GetFocusedRowCellValue("cevapID"));
            choID = Convert.ToInt32(gridView_soruList.GetFocusedRowCellValue("secimID"));

            if (gridView_soruList.GetFocusedRowCellValue("questionTypeid") != null)
                cmb_soruTipi.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("questionTypeid");
            if (gridView_soruList.GetFocusedRowCellValue("lessonid") != null)
                cmb_ders.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("lessonid");
            if (gridView_soruList.GetFocusedRowCellValue("subjectid") != null)
                cmb_konu.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("subjectid");
            if (gridView_soruList.GetFocusedRowCellValue("degreeOffDiffid") != null)
                cmb_zorlukDerecesi.SelectedValue = (int)gridView_soruList.GetFocusedRowCellValue("degreeOffDiffid");
            if (gridView_soruList.GetFocusedRowCellValue("Puan") != null)
                cmb_puan.Text = gridView_soruList.GetFocusedRowCellValue("Puan").ToString();
            if (gridView_soruList.GetFocusedRowCellValue("Soru") != null)
                richTxt_soru.Text = gridView_soruList.GetFocusedRowCellValue("Soru").ToString();
            if (gridView_soruList.GetFocusedRowCellValue("Cevap") != null)
                richTxt_cevap.Text = (string)gridView_soruList.GetFocusedRowCellValue("Cevap");
            if (gridView_soruList.GetFocusedRowCellValue("A_secenegi") != null)
                textEdit_ASikki.Text = (string)gridView_soruList.GetFocusedRowCellValue("A_secenegi");
            if (gridView_soruList.GetFocusedRowCellValue("B_secenegi") != null)
                textEdit_BSikki.Text = (string)gridView_soruList.GetFocusedRowCellValue("B_secenegi");
            if (gridView_soruList.GetFocusedRowCellValue("C_secenegi") != null)
                textEdit_CSikki.Text = (string)gridView_soruList.GetFocusedRowCellValue("C_secenegi");
            if (gridView_soruList.GetFocusedRowCellValue("D_secenegi") != null)
                textEdit_DSikki.Text = (string)gridView_soruList.GetFocusedRowCellValue("D_secenegi");
        }

        private void cmb_soruTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmb_soruTipi.SelectedValue == 1)
                xtraTabControl1.TabPages[2].Show();
            else
                xtraTabControl1.TabPages[2].Hide();
        }

        private void cmb_ders_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.subjectLoad(cmb_konu, (int)cmb_ders.SelectedValue);
        }

        private void btn_secenekleriTemizle_Click(object sender, EventArgs e)
        {
            textEdit_ASikki.Text = "";
            textEdit_BSikki.Text = "";
            textEdit_CSikki.Text = "";
            textEdit_DSikki.Text = "";

        }

        public void saveQnsMakerGrid(IList<QuestionMaker> liste)
        {
           // throw new NotImplementedException();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            presenter.search(gridControl_sorular, cmb_kriterler.SelectedIndex, (int)cmb_soruTipi.SelectedValue, (int)cmb_ders.SelectedValue, (int)cmb_konu.SelectedValue, (int)cmb_zorlukDerecesi.SelectedValue, int.Parse(cmb_puan.Text));
        }
    }
}