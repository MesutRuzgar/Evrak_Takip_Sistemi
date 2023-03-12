
namespace EvrakTakipSistemi
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TaxIdentificationNumber = new DataGridViewTextBoxColumn();
            CompanyName = new DataGridViewTextBoxColumn();
            TaxPlateYear = new DataGridViewTextBoxColumn();
            ActivityCertificateDate = new DataGridViewTextBoxColumn();
            SignatureCircularDate = new DataGridViewTextBoxColumn();
            CompanyOfficials = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tbxSearch = new TextBox();
            label2 = new Label();
            mskVkn = new MaskedTextBox();
            label3 = new Label();
            tbxAd = new TextBox();
            tbxVergiYili = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            mskFaaliyet = new MaskedTextBox();
            btnIletisim = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnTemizle = new Button();
            label8 = new Label();
            tbxId = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            rtbxFirmaYetkili = new RichTextBox();
            pictureBox1 = new PictureBox();
            mskImza = new MaskedTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 306);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 274);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, TaxIdentificationNumber, CompanyName, TaxPlateYear, ActivityCertificateDate, SignatureCircularDate, CompanyOfficials });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1088, 251);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Müşteri No";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // TaxIdentificationNumber
            // 
            TaxIdentificationNumber.DataPropertyName = "TaxIdentificationNumber";
            TaxIdentificationNumber.HeaderText = "VERGİ KİMLİK NUMARASI";
            TaxIdentificationNumber.Name = "TaxIdentificationNumber";
            TaxIdentificationNumber.ReadOnly = true;
            // 
            // CompanyName
            // 
            CompanyName.DataPropertyName = "CompanyName";
            CompanyName.HeaderText = "FİRMA AD";
            CompanyName.Name = "CompanyName";
            CompanyName.ReadOnly = true;
            // 
            // TaxPlateYear
            // 
            TaxPlateYear.DataPropertyName = "TaxPlateYear";
            TaxPlateYear.HeaderText = "VERGİ LEVHASI YILI";
            TaxPlateYear.Name = "TaxPlateYear";
            TaxPlateYear.ReadOnly = true;
            // 
            // ActivityCertificateDate
            // 
            ActivityCertificateDate.DataPropertyName = "ActivityCertificateDate";
            ActivityCertificateDate.HeaderText = "FAALİYET BELGESİ TARİHİ";
            ActivityCertificateDate.Name = "ActivityCertificateDate";
            ActivityCertificateDate.ReadOnly = true;
            // 
            // SignatureCircularDate
            // 
            SignatureCircularDate.DataPropertyName = "SignatureCircularDate";
            SignatureCircularDate.HeaderText = "İMZA SİRKÜLER TARİHİ";
            SignatureCircularDate.Name = "SignatureCircularDate";
            SignatureCircularDate.ReadOnly = true;
            // 
            // CompanyOfficials
            // 
            CompanyOfficials.DataPropertyName = "CompanyOfficials";
            CompanyOfficials.HeaderText = "FİRMA YETKİLİLERİ";
            CompanyOfficials.Name = "CompanyOfficials";
            CompanyOfficials.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 17);
            label1.Name = "label1";
            label1.Size = new Size(186, 18);
            label1.TabIndex = 1;
            label1.Text = "Firma İsmine Göre Arama :";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(219, 14);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(566, 24);
            tbxSearch.TabIndex = 1;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 69);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 3;
            label2.Text = "VKN :";
            // 
            // mskVkn
            // 
            mskVkn.Location = new Point(173, 66);
            mskVkn.Mask = "00000000000";
            mskVkn.Name = "mskVkn";
            mskVkn.Size = new Size(153, 24);
            mskVkn.TabIndex = 2;
            mskVkn.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 99);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 5;
            label3.Text = "FİRMA AD :";
            // 
            // tbxAd
            // 
            tbxAd.Location = new Point(173, 96);
            tbxAd.Name = "tbxAd";
            tbxAd.Size = new Size(153, 24);
            tbxAd.TabIndex = 3;
            // 
            // tbxVergiYili
            // 
            tbxVergiYili.Location = new Point(173, 126);
            tbxVergiYili.Name = "tbxVergiYili";
            tbxVergiYili.Size = new Size(153, 24);
            tbxVergiYili.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 129);
            label4.Name = "label4";
            label4.Size = new Size(152, 18);
            label4.TabIndex = 7;
            label4.Text = "VERGİ LEVHASI YILI :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 42);
            label5.Name = "label5";
            label5.Size = new Size(260, 18);
            label5.TabIndex = 9;
            label5.Text = "FAALİYET BELGESİ ALINDIĞI TARİH :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(373, 72);
            label6.Name = "label6";
            label6.Size = new Size(238, 18);
            label6.TabIndex = 11;
            label6.Text = "İMZA SİRKÜLERİ ALINMA TARİHİ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 102);
            label7.Name = "label7";
            label7.Size = new Size(149, 18);
            label7.TabIndex = 13;
            label7.Text = "FİRMA YETKİLİLERİ :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mskImza);
            groupBox2.Controls.Add(mskFaaliyet);
            groupBox2.Controls.Add(btnIletisim);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbxId);
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(rtbxFirmaYetkili);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(mskVkn);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbxAd);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbxVergiYili);
            groupBox2.Location = new Point(15, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(782, 253);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // mskFaaliyet
            // 
            mskFaaliyet.Location = new Point(617, 36);
            mskFaaliyet.Mask = "00/00/0000";
            mskFaaliyet.Name = "mskFaaliyet";
            mskFaaliyet.Size = new Size(153, 24);
            mskFaaliyet.TabIndex = 24;
            mskFaaliyet.ValidatingType = typeof(DateTime);
            // 
            // btnIletisim
            // 
            btnIletisim.Location = new Point(617, 214);
            btnIletisim.Name = "btnIletisim";
            btnIletisim.Size = new Size(153, 33);
            btnIletisim.TabIndex = 12;
            btnIletisim.Text = "İLETİŞİM BİLGİLERİ";
            btnIletisim.UseVisualStyleBackColor = true;
            btnIletisim.Click += btnIletisim_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(300, 203);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(300, 164);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(98, 203);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(98, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(354, 203);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(129, 33);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 39);
            label8.Name = "label8";
            label8.Size = new Size(110, 18);
            label8.TabIndex = 15;
            label8.Text = "MÜŞTERİ NO :";
            // 
            // tbxId
            // 
            tbxId.Enabled = false;
            tbxId.Location = new Point(173, 36);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(153, 24);
            tbxId.TabIndex = 14;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(152, 203);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(129, 33);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(354, 164);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(129, 33);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(152, 164);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(129, 33);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // rtbxFirmaYetkili
            // 
            rtbxFirmaYetkili.Location = new Point(617, 99);
            rtbxFirmaYetkili.Name = "rtbxFirmaYetkili";
            rtbxFirmaYetkili.Size = new Size(153, 109);
            rtbxFirmaYetkili.TabIndex = 7;
            rtbxFirmaYetkili.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // mskImza
            // 
            mskImza.Location = new Point(617, 69);
            mskImza.Mask = "00/00/0000";
            mskImza.Name = "mskImza";
            mskImza.Size = new Size(153, 24);
            mskImza.TabIndex = 25;
            mskImza.ValidatingType = typeof(DateTime);
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1118, 592);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(tbxSearch);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Angün Döviz Ve Altın Ticaret A.Ş.  --- Desing By Mesut RÜZGAR";
            Load += AnaForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskVkn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxVergiYili;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RichTextBox rtbxFirmaYetkili;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIletisim;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TaxIdentificationNumber;
        private new DataGridViewTextBoxColumn CompanyName;
        private DataGridViewTextBoxColumn TaxPlateYear;
        private DataGridViewTextBoxColumn ActivityCertificateDate;
        private DataGridViewTextBoxColumn SignatureCircularDate;
        private DataGridViewTextBoxColumn CompanyOfficials;
        private DateTimePicker dtpFaaliyet;
        private DateTimePicker dtpImza;
        private MaskedTextBox mskFaaliyet;
        private MaskedTextBox mskImza;
    }
}

