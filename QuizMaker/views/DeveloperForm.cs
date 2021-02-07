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

namespace QuizMaker.views
{
    public partial class DeveloperForm : XtraForm
    {
        public DeveloperForm()
        {
            InitializeComponent();
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {

        }
        #region Singleton D.P.
        private static DeveloperForm myForm;

        public static DeveloperForm myDeveloperForm()
        {
            if (myForm == null)
                myForm = new DeveloperForm();
            return myForm;
        }

        private void DeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myForm = null;
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void listbox_source_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(listbox_source.SelectedItem.ToString());

        }
    }
}
