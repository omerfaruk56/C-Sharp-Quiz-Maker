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
using QuizMaker.presenters;

namespace QuizMaker.views
{
    public partial class ExamWriterForm : XtraForm, IExamWriterView
    {
        ExamWriterPresenter presenter;
        int ansCount;
        int klasikCount;
        public ExamWriterForm()
        {
            InitializeComponent();
            presenter = new ExamWriterPresenter(this);
        }

        private void ExamWriterForm_Load(object sender, EventArgs e)
        {

        }

        #region Singleton D.P.
        private static ExamWriterForm myWriterForm;

        public static ExamWriterForm myExamWriterForm()
        {
            if (myWriterForm == null)
                myWriterForm = new ExamWriterForm();
            return myWriterForm;
        }

        private void ExamWriterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myWriterForm = null;
        }
        #endregion

        public void saveExamWriterGrid(IList<ExamWriter> liste)
        {
            throw new NotImplementedException();
        }

        private void txt_cevapGir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_cevapGir.Text != "")
            {
                listbox_cevaplar.Items.Add(txt_cevapGir.Text.ToUpper().Trim());
                txt_cevapGir.Text = "";
                if (ansCount == listbox_cevapAnahtari.Items.Count - 1)
                {
                    txt_cevapGir.Enabled = false;
                    ansCount = 0;
                    return;
                }
                ansCount++;
            }
        }

        private void btn_listCevaplarSil_Click(object sender, EventArgs e)
        {
            listbox_cevaplar.Items.Clear();
            txt_cevapGir.Enabled = true;
        }

        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            listbox_cevapAnahtari.Items.Clear();
            presenter.answerKey(listbox_cevapAnahtari, txt_sinavAdi.Text, txt_grupAdi.Text.ToUpper().Trim());
            listbox_sonuclar.Items.Add(presenter.examResult(listbox_cevaplar, listbox_cevapAnahtari, txt_sinavAdi.Text, txt_grupAdi.Text.ToUpper().Trim()));
        }

        private void btn_cevaplariListele_Click(object sender, EventArgs e)
        {
            listbox_cevapAnahtari.Items.Clear();
            presenter.answerKey(listbox_cevapAnahtari, txt_sinavAdi.Text, txt_grupAdi.Text);
        }

        private void txt_puanGir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_puanGir.Text != "")
            {
                list_ogrenciPuanList.Items.Add(txt_puanGir.Text.ToUpper().Trim());
                txt_puanGir.Text = "";
                if (klasikCount == list_klasikCevapList.Items.Count - 1)
                {
                    txt_puanGir.Enabled = false;
                    klasikCount = 0;
                    return;
                }
                klasikCount++;
            }
        }

        private void btn_klasikCevaplariList_Click(object sender, EventArgs e)
        {
            list_klasikCevapList.Items.Clear();
            presenter.answerKey(list_klasikCevapList, txt_sinavAdi.Text, txt_grupAdi.Text);
        }

        private void btn_KlasikSonuc_Click(object sender, EventArgs e)
        {
            list_klasikSonuc.Items.Add(presenter.totalScore(list_ogrenciPuanList));
        }

        private void btn_KlasikTemizle_Click(object sender, EventArgs e)
        {
            list_ogrenciPuanList.Items.Clear();
            txt_puanGir.Enabled = true;
        }

        private void btn_genelSonuc_Click(object sender, EventArgs e)
        {
            lbl_ortPuan.Text = presenter.averageScore(list_klasikSonuc).ToString();
            lbl_enDusukPuan.Text = presenter.lowScore(list_klasikSonuc).ToString();
            lbl_enYuksekPuan.Text = presenter.highScore(list_klasikSonuc).ToString();
        }

        private void list_klasikCevapList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_klasikCevapList.SelectedItem != null)
                richEditControl_cevapGoster.Text = list_klasikCevapList.SelectedItem.ToString();
        }

        private void btn_klasikSifirla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sıfırlamak istediğinizden emin misiniz?", "Sıfırlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                list_klasikSonuc.Items.Clear();
                list_ogrenciPuanList.Items.Clear();
                txt_puanGir.Enabled = true;
                lbl_enDusukPuan.Text = "sonuç";
                lbl_enYuksekPuan.Text = "sonuç";
                lbl_ortPuan.Text = "sonuç";
            }

        }

        private void btn_sifirla_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sıfırlamak istediğinizden emin misiniz?", "Sıfırlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listbox_sonuclar.Items.Clear();
                listbox_cevaplar.Items.Clear();
                txt_cevapGir.Enabled = true;
            }
        }
    }
}