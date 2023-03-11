namespace EvrakTakipSistemi
{
    partial class IletısımKayıt
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
            tbxEmail = new TextBox();
            label2 = new Label();
            mskTelefon = new MaskedTextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 13);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 0;
            label1.Text = "TELEFON :";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(150, 40);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(131, 24);
            tbxEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 43);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 2;
            label2.Text = "E-POSTA :";
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(150, 10);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(131, 24);
            mskTelefon.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(150, 71);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(131, 31);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // IletısımKayıt
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(353, 114);
            Controls.Add(btnKaydet);
            Controls.Add(mskTelefon);
            Controls.Add(tbxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "IletısımKayıt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İLETİŞİM BİLGİLERİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Button btnKaydet;
    }
}