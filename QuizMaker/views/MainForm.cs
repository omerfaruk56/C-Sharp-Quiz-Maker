using QuizMaker.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizMaker.Views
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();

        }

        private void btn_soruOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                QnsMakerForm newQnsForm = QnsMakerForm.myQnsMakerForm();
                newQnsForm.MdiParent = this;
                newQnsForm.Show();
                newQnsForm.Activate();
            }
            catch
            {
                if (!this.MdiChildren.OfType<QnsMakerForm>().Any())
                {
                    QnsMakerForm f = new QnsMakerForm();
                    f.Owner = this;
                    f.MdiParent = this;
                    f.Show();
                    f.Activate();
                }
            }
        }

        private void btn_soruOlusturma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExamMakerForm newExamForm = ExamMakerForm.myExamMakerForm();
            newExamForm.MdiParent = this;
            newExamForm.Show();
            newExamForm.Activate();

        }

        private void btn_zorlukDerecesiBelirle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DegreeOfDiffForm newDiffForm = DegreeOfDiffForm.myDegreeOffDiffForm();
            newDiffForm.MdiParent = this;
            newDiffForm.Show();
            newDiffForm.Activate();


        }

        private void btn_SoruKategorisiOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SubjectForm newSubjectForm = SubjectForm.mySubjectForm();
            newSubjectForm.MdiParent = this;
            newSubjectForm.Show();
            newSubjectForm.Activate();



        }

        private void btn_cevapKagidiOku_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            ExamWriterForm newWriterForm = ExamWriterForm.myExamWriterForm();
            newWriterForm.MdiParent = this;
            newWriterForm.Show();
            newWriterForm.Activate();


        }

        private void btn_yazilimcilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeveloperForm newDeveloperForm = DeveloperForm.myDeveloperForm();
            newDeveloperForm.MdiParent = this;
            newDeveloperForm.Show();
            newDeveloperForm.Activate();
        }

        private void btn_hakkinda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutForm newAboutForm = AboutForm.myAboutForm();
            newAboutForm.MdiParent = this;
            newAboutForm.Show();
            newAboutForm.Activate();
        }
    }
}
