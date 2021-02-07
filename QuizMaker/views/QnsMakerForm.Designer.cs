namespace QuizMaker.Views
{
    partial class QnsMakerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QnsMakerForm));
            this.btn_soruSil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_soruguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_soruekle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_sorular = new DevExpress.XtraGrid.GridControl();
            this.gridView_soruList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_sorulariListele = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.richTxt_soru = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.richTxt_cevap = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btn_secenekleriTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_DSikki = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_CSikki = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_BSikki = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_ASikki = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_puan = new System.Windows.Forms.ComboBox();
            this.cmb_zorlukDerecesi = new System.Windows.Forms.ComboBox();
            this.cmb_konu = new System.Windows.Forms.ComboBox();
            this.cmb_ders = new System.Windows.Forms.ComboBox();
            this.cmb_soruTipi = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_ara = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_kriterler = new System.Windows.Forms.ComboBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_soruList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DSikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CSikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_BSikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ASikki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_soruSil
            // 
            this.btn_soruSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_soruSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_soruSil.ImageOptions.Image")));
            this.btn_soruSil.Location = new System.Drawing.Point(17, 484);
            this.btn_soruSil.Name = "btn_soruSil";
            this.btn_soruSil.Size = new System.Drawing.Size(121, 44);
            this.btn_soruSil.TabIndex = 13;
            this.btn_soruSil.Text = "Soru Sil";
            this.btn_soruSil.Click += new System.EventHandler(this.btn_soruSil_Click);
            // 
            // btn_soruguncelle
            // 
            this.btn_soruguncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_soruguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_soruguncelle.ImageOptions.Image")));
            this.btn_soruguncelle.Location = new System.Drawing.Point(144, 484);
            this.btn_soruguncelle.Name = "btn_soruguncelle";
            this.btn_soruguncelle.Size = new System.Drawing.Size(121, 44);
            this.btn_soruguncelle.TabIndex = 12;
            this.btn_soruguncelle.Text = "Soru Güncelle";
            this.btn_soruguncelle.Click += new System.EventHandler(this.btn_soruguncelle_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl5.Location = new System.Drawing.Point(17, 372);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 19);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Puan:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 314);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(115, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Zorluk Derecesi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 256);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Konu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 198);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ders:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Soru Tipi:";
            // 
            // btn_soruekle
            // 
            this.btn_soruekle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_soruekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_soruekle.ImageOptions.Image")));
            this.btn_soruekle.Location = new System.Drawing.Point(144, 436);
            this.btn_soruekle.Name = "btn_soruekle";
            this.btn_soruekle.Size = new System.Drawing.Size(121, 42);
            this.btn_soruekle.TabIndex = 0;
            this.btn_soruekle.Text = "Soru Ekle";
            this.btn_soruekle.Click += new System.EventHandler(this.btn_soruekle_Click);
            // 
            // gridControl_sorular
            // 
            this.gridControl_sorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_sorular.Location = new System.Drawing.Point(0, 0);
            this.gridControl_sorular.MainView = this.gridView_soruList;
            this.gridControl_sorular.Name = "gridControl_sorular";
            this.gridControl_sorular.Size = new System.Drawing.Size(912, 343);
            this.gridControl_sorular.TabIndex = 0;
            this.gridControl_sorular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_soruList});
            // 
            // gridView_soruList
            // 
            this.gridView_soruList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView_soruList.GridControl = this.gridControl_sorular;
            this.gridView_soruList.Name = "gridView_soruList";
            this.gridView_soruList.OptionsBehavior.Editable = false;
            this.gridView_soruList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_soruList_FocusedRowChanged);
            // 
            // btn_sorulariListele
            // 
            this.btn_sorulariListele.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_sorulariListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sorulariListele.ImageOptions.Image")));
            this.btn_sorulariListele.Location = new System.Drawing.Point(17, 436);
            this.btn_sorulariListele.Name = "btn_sorulariListele";
            this.btn_sorulariListele.Size = new System.Drawing.Size(121, 42);
            this.btn_sorulariListele.TabIndex = 14;
            this.btn_sorulariListele.Text = "Soruları Listele";
            this.btn_sorulariListele.Click += new System.EventHandler(this.btn_sorulariListele_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(293, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_sorular);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(912, 662);
            this.splitContainerControl1.SplitterPosition = 343;
            this.splitContainerControl1.TabIndex = 17;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(912, 314);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.richTxt_soru);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(902, 282);
            this.xtraTabPage1.Text = "Soru";
            // 
            // richTxt_soru
            // 
            this.richTxt_soru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxt_soru.Location = new System.Drawing.Point(0, 0);
            this.richTxt_soru.Name = "richTxt_soru";
            this.richTxt_soru.Size = new System.Drawing.Size(902, 282);
            this.richTxt_soru.TabIndex = 16;
            this.richTxt_soru.Text = "richEditControl1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.richTxt_cevap);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(902, 282);
            this.xtraTabPage2.Text = "Cevap";
            // 
            // richTxt_cevap
            // 
            this.richTxt_cevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxt_cevap.Location = new System.Drawing.Point(0, 0);
            this.richTxt_cevap.Name = "richTxt_cevap";
            this.richTxt_cevap.Size = new System.Drawing.Size(902, 282);
            this.richTxt_cevap.TabIndex = 17;
            this.richTxt_cevap.Text = "richEditControl2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.btn_secenekleriTemizle);
            this.xtraTabPage3.Controls.Add(this.textEdit_DSikki);
            this.xtraTabPage3.Controls.Add(this.labelControl9);
            this.xtraTabPage3.Controls.Add(this.labelControl7);
            this.xtraTabPage3.Controls.Add(this.textEdit_CSikki);
            this.xtraTabPage3.Controls.Add(this.textEdit_BSikki);
            this.xtraTabPage3.Controls.Add(this.textEdit_ASikki);
            this.xtraTabPage3.Controls.Add(this.labelControl6);
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(902, 282);
            this.xtraTabPage3.Text = "Çoktan Seçmeli";
            // 
            // btn_secenekleriTemizle
            // 
            this.btn_secenekleriTemizle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_secenekleriTemizle.Location = new System.Drawing.Point(726, 28);
            this.btn_secenekleriTemizle.Name = "btn_secenekleriTemizle";
            this.btn_secenekleriTemizle.Size = new System.Drawing.Size(110, 35);
            this.btn_secenekleriTemizle.TabIndex = 3;
            this.btn_secenekleriTemizle.Text = "Temizle";
            this.btn_secenekleriTemizle.Click += new System.EventHandler(this.btn_secenekleriTemizle_Click);
            // 
            // textEdit_DSikki
            // 
            this.textEdit_DSikki.Location = new System.Drawing.Point(74, 132);
            this.textEdit_DSikki.Name = "textEdit_DSikki";
            this.textEdit_DSikki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_DSikki.Properties.Appearance.Options.UseFont = true;
            this.textEdit_DSikki.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit_DSikki.Size = new System.Drawing.Size(590, 28);
            this.textEdit_DSikki.TabIndex = 18;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl9.Location = new System.Drawing.Point(13, 136);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 19);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "D Şıkkı:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl7.Location = new System.Drawing.Point(13, 68);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 19);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "B Şıkkı:";
            // 
            // textEdit_CSikki
            // 
            this.textEdit_CSikki.Location = new System.Drawing.Point(74, 98);
            this.textEdit_CSikki.Name = "textEdit_CSikki";
            this.textEdit_CSikki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_CSikki.Properties.Appearance.Options.UseFont = true;
            this.textEdit_CSikki.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit_CSikki.Size = new System.Drawing.Size(590, 28);
            this.textEdit_CSikki.TabIndex = 16;
            // 
            // textEdit_BSikki
            // 
            this.textEdit_BSikki.Location = new System.Drawing.Point(74, 64);
            this.textEdit_BSikki.Name = "textEdit_BSikki";
            this.textEdit_BSikki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_BSikki.Properties.Appearance.Options.UseFont = true;
            this.textEdit_BSikki.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit_BSikki.Size = new System.Drawing.Size(590, 28);
            this.textEdit_BSikki.TabIndex = 14;
            // 
            // textEdit_ASikki
            // 
            this.textEdit_ASikki.Location = new System.Drawing.Point(74, 30);
            this.textEdit_ASikki.Name = "textEdit_ASikki";
            this.textEdit_ASikki.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_ASikki.Properties.Appearance.Options.UseFont = true;
            this.textEdit_ASikki.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit_ASikki.Size = new System.Drawing.Size(590, 28);
            this.textEdit_ASikki.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl6.Location = new System.Drawing.Point(13, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 19);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "A Şıkkı:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl8.Location = new System.Drawing.Point(13, 102);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 19);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "C Şıkkı:";
            // 
            // cmb_puan
            // 
            this.cmb_puan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_puan.FormattingEnabled = true;
            this.cmb_puan.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmb_puan.Location = new System.Drawing.Point(16, 397);
            this.cmb_puan.Name = "cmb_puan";
            this.cmb_puan.Size = new System.Drawing.Size(248, 27);
            this.cmb_puan.TabIndex = 19;
            // 
            // cmb_zorlukDerecesi
            // 
            this.cmb_zorlukDerecesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_zorlukDerecesi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_zorlukDerecesi.FormattingEnabled = true;
            this.cmb_zorlukDerecesi.Location = new System.Drawing.Point(16, 339);
            this.cmb_zorlukDerecesi.Name = "cmb_zorlukDerecesi";
            this.cmb_zorlukDerecesi.Size = new System.Drawing.Size(248, 27);
            this.cmb_zorlukDerecesi.TabIndex = 18;
            // 
            // cmb_konu
            // 
            this.cmb_konu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_konu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_konu.FormattingEnabled = true;
            this.cmb_konu.Location = new System.Drawing.Point(16, 281);
            this.cmb_konu.Name = "cmb_konu";
            this.cmb_konu.Size = new System.Drawing.Size(248, 27);
            this.cmb_konu.TabIndex = 17;
            // 
            // cmb_ders
            // 
            this.cmb_ders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ders.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ders.FormattingEnabled = true;
            this.cmb_ders.Location = new System.Drawing.Point(16, 223);
            this.cmb_ders.Name = "cmb_ders";
            this.cmb_ders.Size = new System.Drawing.Size(248, 27);
            this.cmb_ders.TabIndex = 16;
            this.cmb_ders.SelectedIndexChanged += new System.EventHandler(this.cmb_ders_SelectedIndexChanged);
            // 
            // cmb_soruTipi
            // 
            this.cmb_soruTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_soruTipi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_soruTipi.FormattingEnabled = true;
            this.cmb_soruTipi.Location = new System.Drawing.Point(16, 165);
            this.cmb_soruTipi.Name = "cmb_soruTipi";
            this.cmb_soruTipi.Size = new System.Drawing.Size(248, 27);
            this.cmb_soruTipi.TabIndex = 15;
            this.cmb_soruTipi.SelectedIndexChanged += new System.EventHandler(this.cmb_soruTipi_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.btn_soruguncelle);
            this.panelControl1.Controls.Add(this.cmb_puan);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btn_soruSil);
            this.panelControl1.Controls.Add(this.cmb_zorlukDerecesi);
            this.panelControl1.Controls.Add(this.btn_sorulariListele);
            this.panelControl1.Controls.Add(this.btn_soruekle);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cmb_konu);
            this.panelControl1.Controls.Add(this.cmb_soruTipi);
            this.panelControl1.Controls.Add(this.cmb_ders);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(293, 662);
            this.panelControl1.TabIndex = 18;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_ara);
            this.groupControl1.Controls.Add(this.cmb_kriterler);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(16, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 122);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Arama";
            // 
            // btn_ara
            // 
            this.btn_ara.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Appearance.Options.UseFont = true;
            this.btn_ara.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btn_ara.Location = new System.Drawing.Point(10, 86);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(222, 23);
            this.btn_ara.TabIndex = 1;
            this.btn_ara.Text = "Ara";
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // cmb_kriterler
            // 
            this.cmb_kriterler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kriterler.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kriterler.FormattingEnabled = true;
            this.cmb_kriterler.Items.AddRange(new object[] {
            "Soru Tipi",
            "Ders",
            "Konu",
            "Zorluk Derecesi",
            "Puan"});
            this.cmb_kriterler.Location = new System.Drawing.Point(10, 53);
            this.cmb_kriterler.Name = "cmb_kriterler";
            this.cmb_kriterler.Size = new System.Drawing.Size(222, 27);
            this.cmb_kriterler.TabIndex = 20;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl10.Location = new System.Drawing.Point(10, 28);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(100, 19);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Arama Kriteri:";
            // 
            // QnsMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 662);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "QnsMakerForm";
            this.Text = "Soru İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QnsMakerForm_FormClosing);
            this.Load += new System.EventHandler(this.QnsMakerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_sorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_soruList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DSikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CSikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_BSikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ASikki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl_sorular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_soruList;
        private DevExpress.XtraEditors.SimpleButton btn_soruSil;
        private DevExpress.XtraEditors.SimpleButton btn_soruguncelle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_soruekle;
        private DevExpress.XtraEditors.SimpleButton btn_sorulariListele;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ComboBox cmb_puan;
        private System.Windows.Forms.ComboBox cmb_zorlukDerecesi;
        private System.Windows.Forms.ComboBox cmb_konu;
        private System.Windows.Forms.ComboBox cmb_ders;
        private System.Windows.Forms.ComboBox cmb_soruTipi;
        private DevExpress.XtraRichEdit.RichEditControl richTxt_cevap;
        private DevExpress.XtraEditors.TextEdit textEdit_DSikki;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit_CSikki;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit_BSikki;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit_ASikki;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        public DevExpress.XtraRichEdit.RichEditControl richTxt_soru;
        private DevExpress.XtraEditors.SimpleButton btn_secenekleriTemizle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ara;
        private System.Windows.Forms.ComboBox cmb_kriterler;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}