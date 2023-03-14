namespace EvrakTakipSistemi
{
    partial class IletisimFormu
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
            label1 = new Label();
            tbxAd = new TextBox();
            mskTel = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxId = new TextBox();
            label5 = new Label();
            btnGuncelle = new Button();
            tbxEmail = new TextBox();
            tbxVKN = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "VERGİ KİMLİK NO :";
            // 
            // tbxAd
            // 
            tbxAd.Enabled = false;
            tbxAd.Location = new Point(167, 82);
            tbxAd.Name = "tbxAd";
            tbxAd.Size = new Size(240, 26);
            tbxAd.TabIndex = 1;
            // 
            // mskTel
            // 
            mskTel.Location = new Point(167, 114);
            mskTel.Mask = "(999) 000-0000";
            mskTel.Name = "mskTel";
            mskTel.Size = new Size(240, 26);
            mskTel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 6;
            label2.Text = "MÜŞTERİ ÜNVANI :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 117);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "TELEFON :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 149);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 9;
            label4.Text = "E-POSTA:";
            // 
            // tbxId
            // 
            tbxId.Enabled = false;
            tbxId.Location = new Point(167, 18);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(240, 26);
            tbxId.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 21);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 10;
            label5.Text = "MÜŞTERİ NO :";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(167, 178);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(240, 31);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(167, 146);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(240, 26);
            tbxEmail.TabIndex = 12;
            // 
            // tbxVKN
            // 
            tbxVKN.Enabled = false;
            tbxVKN.Location = new Point(167, 50);
            tbxVKN.Name = "tbxVKN";
            tbxVKN.Size = new Size(240, 26);
            tbxVKN.TabIndex = 8;
            // 
            // IletisimFormu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(436, 220);
            Controls.Add(tbxEmail);
            Controls.Add(btnGuncelle);
            Controls.Add(tbxId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbxVKN);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(mskTel);
            Controls.Add(tbxAd);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "IletisimFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri İletişim Formu";
            Load += IletisimFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxEmail;
        private TextBox tbxVKN;
    }
}