using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaker
{
    partial class AboutForm : XtraForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        #region Singleton D.P.
        private static AboutForm myForm;

        public static AboutForm myAboutForm()
        {
            if (myForm == null)
                myForm = new AboutForm();
            return myForm;
        }
    
        private void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            myForm = null;
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
