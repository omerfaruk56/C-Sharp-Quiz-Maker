namespace QuizMaker.views
{
    partial class SubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_dersSil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dersGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dersEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ders = new DevExpress.XtraEditors.TextEdit();
            this.cmb_ders1 = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_konu = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_konuSil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_konuGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_konu = new DevExpress.XtraEditors.TextEdit();
            this.btn_konuEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ders2 = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_konu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_dersSil);
            this.groupControl1.Controls.Add(this.btn_dersGuncelle);
            this.groupControl1.Controls.Add(this.btn_dersEkle);
            this.groupControl1.Controls.Add(this.txt_ders);
            this.groupControl1.Controls.Add(this.cmb_ders1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 203);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ders İşlemleri";
            // 
            // btn_dersSil
            // 
            this.btn_dersSil.Location = new System.Drawing.Point(179, 154);
            this.btn_dersSil.Name = "btn_dersSil";
            this.btn_dersSil.Size = new System.Drawing.Size(75, 23);
            this.btn_dersSil.TabIndex = 7;
            this.btn_dersSil.Text = "sil";
            this.btn_dersSil.Click += new System.EventHandler(this.btn_dersSil_Click);
            // 
            // btn_dersGuncelle
            // 
            this.btn_dersGuncelle.Location = new System.Drawing.Point(98, 154);
            this.btn_dersGuncelle.Name = "btn_dersGuncelle";
            this.btn_dersGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_dersGuncelle.TabIndex = 6;
            this.btn_dersGuncelle.Text = "Güncelle";
            this.btn_dersGuncelle.Click += new System.EventHandler(this.btn_dersGuncelle_Click);
            // 
            // btn_dersEkle
            // 
            this.btn_dersEkle.Location = new System.Drawing.Point(17, 154);
            this.btn_dersEkle.Name = "btn_dersEkle";
            this.btn_dersEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_dersEkle.TabIndex = 5;
            this.btn_dersEkle.Text = "Ekle";
            this.btn_dersEkle.Click += new System.EventHandler(this.btn_dersEkle_Click);
            // 
            // txt_ders
            // 
            this.txt_ders.Location = new System.Drawing.Point(63, 75);
            this.txt_ders.Name = "txt_ders";
            this.txt_ders.Size = new System.Drawing.Size(182, 20);
            this.txt_ders.TabIndex = 1;
            // 
            // cmb_ders1
            // 
            this.cmb_ders1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ders1.FormattingEnabled = true;
            this.cmb_ders1.Location = new System.Drawing.Point(63, 36);
            this.cmb_ders1.Name = "cmb_ders1";
            this.cmb_ders1.Size = new System.Drawing.Size(182, 21);
            this.cmb_ders1.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Ders:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(19, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Dersler:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cmb_konu);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.btn_konuSil);
            this.groupControl2.Controls.Add(this.btn_konuGuncelle);
            this.groupControl2.Controls.Add(this.txt_konu);
            this.groupControl2.Controls.Add(this.btn_konuEkle);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.cmb_ders2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(301, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(282, 203);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Konu İşlemleri";
            // 
            // cmb_konu
            // 
            this.cmb_konu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_konu.FormattingEnabled = true;
            this.cmb_konu.Location = new System.Drawing.Point(66, 75);
            this.cmb_konu.Name = "cmb_konu";
            this.cmb_konu.Size = new System.Drawing.Size(182, 21);
            this.cmb_konu.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(22, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Konular:";
            // 
            // btn_konuSil
            // 
            this.btn_konuSil.Location = new System.Drawing.Point(184, 154);
            this.btn_konuSil.Name = "btn_konuSil";
            this.btn_konuSil.Size = new System.Drawing.Size(75, 23);
            this.btn_konuSil.TabIndex = 10;
            this.btn_konuSil.Text = "sil";
            this.btn_konuSil.Click += new System.EventHandler(this.btn_konuSil_Click);
            // 
            // btn_konuGuncelle
            // 
            this.btn_konuGuncelle.Location = new System.Drawing.Point(103, 154);
            this.btn_konuGuncelle.Name = "btn_konuGuncelle";
            this.btn_konuGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_konuGuncelle.TabIndex = 9;
            this.btn_konuGuncelle.Text = "Güncelle";
            this.btn_konuGuncelle.Click += new System.EventHandler(this.btn_konuGuncelle_Click);
            // 
            // txt_konu
            // 
            this.txt_konu.Location = new System.Drawing.Point(66, 111);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Size = new System.Drawing.Size(182, 20);
            this.txt_konu.TabIndex = 7;
            // 
            // btn_konuEkle
            // 
            this.btn_konuEkle.Location = new System.Drawing.Point(22, 154);
            this.btn_konuEkle.Name = "btn_konuEkle";
            this.btn_konuEkle.Size = new System.Drawing.Size(75, 23);
            this.btn_konuEkle.TabIndex = 8;
            this.btn_konuEkle.Text = "Ekle";
            this.btn_konuEkle.Click += new System.EventHandler(this.btn_konuEkle_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Konu:";
            // 
            // cmb_ders2
            // 
            this.cmb_ders2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ders2.FormattingEnabled = true;
            this.cmb_ders2.Location = new System.Drawing.Point(66, 36);
            this.cmb_ders2.Name = "cmb_ders2";
            this.cmb_ders2.Size = new System.Drawing.Size(182, 21);
            this.cmb_ders2.TabIndex = 6;
            this.cmb_ders2.SelectedIndexChanged += new System.EventHandler(this.cmb_ders2_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Dersler:";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 227);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders ve Konu Ekleme İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectForm_FormClosing);
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_konu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cmb_ders1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_dersSil;
        private DevExpress.XtraEditors.SimpleButton btn_dersGuncelle;
        private DevExpress.XtraEditors.SimpleButton btn_dersEkle;
        private DevExpress.XtraEditors.TextEdit txt_ders;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_konuSil;
        private DevExpress.XtraEditors.SimpleButton btn_konuGuncelle;
        private DevExpress.XtraEditors.TextEdit txt_konu;
        private DevExpress.XtraEditors.SimpleButton btn_konuEkle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmb_ders2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmb_konu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}