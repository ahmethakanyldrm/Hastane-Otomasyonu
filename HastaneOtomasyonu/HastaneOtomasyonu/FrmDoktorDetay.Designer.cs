namespace HastaneOtomasyonu
{
    partial class FrmDoktorDetay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblDoktorAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblDoktorTC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tblRandevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneProjeDataSet = new HastaneOtomasyonu.HastaneProjeDataSet();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuyuru = new DevExpress.XtraEditors.SimpleButton();
            this.btnBilgiDuzenleme = new DevExpress.XtraEditors.SimpleButton();
            this.tbl_RandevularTableAdapter = new HastaneOtomasyonu.HastaneProjeDataSetTableAdapters.Tbl_RandevularTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Olive;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.lblDoktorAdSoyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblDoktorTC);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(1, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 234);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Doktor Bilgisi";
            // 
            // lblDoktorAdSoyad
            // 
            this.lblDoktorAdSoyad.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorAdSoyad.Appearance.Options.UseFont = true;
            this.lblDoktorAdSoyad.Location = new System.Drawing.Point(173, 122);
            this.lblDoktorAdSoyad.Name = "lblDoktorAdSoyad";
            this.lblDoktorAdSoyad.Size = new System.Drawing.Size(107, 22);
            this.lblDoktorAdSoyad.TabIndex = 21;
            this.lblDoktorAdSoyad.Text = "NULL NULL";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(75, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 22);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Ad Soyad:";
            // 
            // lblDoktorTC
            // 
            this.lblDoktorTC.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorTC.Appearance.Options.UseFont = true;
            this.lblDoktorTC.Location = new System.Drawing.Point(173, 75);
            this.lblDoktorTC.Name = "lblDoktorTC";
            this.lblDoktorTC.Size = new System.Drawing.Size(110, 22);
            this.lblDoktorTC.TabIndex = 19;
            this.lblDoktorTC.Text = "00000000000";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(121, 22);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "TC Kimlik No:";
            // 
            // tblRandevularBindingSource
            // 
            this.tblRandevularBindingSource.DataMember = "Tbl_Randevular";
            this.tblRandevularBindingSource.DataSource = this.hastaneProjeDataSet;
            // 
            // hastaneProjeDataSet
            // 
            this.hastaneProjeDataSet.DataSetName = "HastaneProjeDataSet";
            this.hastaneProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnCikis);
            this.groupControl4.Controls.Add(this.btnDuyuru);
            this.groupControl4.Controls.Add(this.btnBilgiDuzenleme);
            this.groupControl4.Location = new System.Drawing.Point(1, 231);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(415, 239);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.Location = new System.Drawing.Point(113, 107);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(179, 34);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuyuru.Appearance.Options.UseFont = true;
            this.btnDuyuru.Location = new System.Drawing.Point(251, 44);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(110, 34);
            this.btnDuyuru.TabIndex = 1;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // btnBilgiDuzenleme
            // 
            this.btnBilgiDuzenleme.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiDuzenleme.Appearance.Options.UseFont = true;
            this.btnBilgiDuzenleme.Location = new System.Drawing.Point(48, 44);
            this.btnBilgiDuzenleme.Name = "btnBilgiDuzenleme";
            this.btnBilgiDuzenleme.Size = new System.Drawing.Size(110, 34);
            this.btnBilgiDuzenleme.TabIndex = 0;
            this.btnBilgiDuzenleme.Text = "Bilgi Düzenle";
            this.btnBilgiDuzenleme.Click += new System.EventHandler(this.btnBilgiDuzenleme_Click);
            // 
            // tbl_RandevularTableAdapter
            // 
            this.tbl_RandevularTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(415, 471);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRandevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblDoktorAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblDoktorTC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnDuyuru;
        private DevExpress.XtraEditors.SimpleButton btnBilgiDuzenleme;
        private HastaneProjeDataSet hastaneProjeDataSet;
        private System.Windows.Forms.BindingSource tblRandevularBindingSource;
        private HastaneProjeDataSetTableAdapters.Tbl_RandevularTableAdapter tbl_RandevularTableAdapter;
    }
}