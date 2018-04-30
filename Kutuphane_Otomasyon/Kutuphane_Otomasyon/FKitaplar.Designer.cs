namespace Kutuphane_Otomasyon
{
    partial class FKitaplar
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
            this.DGKitaplar = new System.Windows.Forms.DataGridView();
            this.GBKitapEkle = new System.Windows.Forms.GroupBox();
            this.BtKitapOlustur = new System.Windows.Forms.Button();
            this.RtbAcikEkle = new System.Windows.Forms.RichTextBox();
            this.TxYazarEkle = new System.Windows.Forms.TextBox();
            this.TxKitapEkle = new System.Windows.Forms.TextBox();
            this.CBTurEkle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBKitapDuzenle = new System.Windows.Forms.GroupBox();
            this.BtKitapDuzenle = new System.Windows.Forms.Button();
            this.BtKitapSil = new System.Windows.Forms.Button();
            this.RtbAcikDz = new System.Windows.Forms.RichTextBox();
            this.TxYazarDz = new System.Windows.Forms.TextBox();
            this.TxKitapDz = new System.Windows.Forms.TextBox();
            this.CBTurDz = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGKitaplar)).BeginInit();
            this.GBKitapEkle.SuspendLayout();
            this.GBKitapDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGKitaplar
            // 
            this.DGKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGKitaplar.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGKitaplar.Location = new System.Drawing.Point(0, 0);
            this.DGKitaplar.Name = "DGKitaplar";
            this.DGKitaplar.Size = new System.Drawing.Size(521, 434);
            this.DGKitaplar.TabIndex = 0;
            this.DGKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGKitaplar_CellClick);
            // 
            // GBKitapEkle
            // 
            this.GBKitapEkle.Controls.Add(this.BtKitapOlustur);
            this.GBKitapEkle.Controls.Add(this.RtbAcikEkle);
            this.GBKitapEkle.Controls.Add(this.TxYazarEkle);
            this.GBKitapEkle.Controls.Add(this.TxKitapEkle);
            this.GBKitapEkle.Controls.Add(this.CBTurEkle);
            this.GBKitapEkle.Controls.Add(this.label4);
            this.GBKitapEkle.Controls.Add(this.label3);
            this.GBKitapEkle.Controls.Add(this.label2);
            this.GBKitapEkle.Controls.Add(this.label1);
            this.GBKitapEkle.Location = new System.Drawing.Point(527, 0);
            this.GBKitapEkle.Name = "GBKitapEkle";
            this.GBKitapEkle.Size = new System.Drawing.Size(255, 217);
            this.GBKitapEkle.TabIndex = 1;
            this.GBKitapEkle.TabStop = false;
            this.GBKitapEkle.Text = "Ekle";
            // 
            // BtKitapOlustur
            // 
            this.BtKitapOlustur.Location = new System.Drawing.Point(169, 187);
            this.BtKitapOlustur.Name = "BtKitapOlustur";
            this.BtKitapOlustur.Size = new System.Drawing.Size(64, 28);
            this.BtKitapOlustur.TabIndex = 17;
            this.BtKitapOlustur.Text = "Oluştur";
            this.BtKitapOlustur.UseVisualStyleBackColor = true;
            this.BtKitapOlustur.Click += new System.EventHandler(this.BtKitapOlustur_Click);
            // 
            // RtbAcikEkle
            // 
            this.RtbAcikEkle.Location = new System.Drawing.Point(74, 125);
            this.RtbAcikEkle.Name = "RtbAcikEkle";
            this.RtbAcikEkle.Size = new System.Drawing.Size(159, 56);
            this.RtbAcikEkle.TabIndex = 7;
            this.RtbAcikEkle.Text = "";
            // 
            // TxYazarEkle
            // 
            this.TxYazarEkle.Location = new System.Drawing.Point(74, 61);
            this.TxYazarEkle.Name = "TxYazarEkle";
            this.TxYazarEkle.Size = new System.Drawing.Size(121, 20);
            this.TxYazarEkle.TabIndex = 6;
            // 
            // TxKitapEkle
            // 
            this.TxKitapEkle.Location = new System.Drawing.Point(74, 25);
            this.TxKitapEkle.Name = "TxKitapEkle";
            this.TxKitapEkle.Size = new System.Drawing.Size(121, 20);
            this.TxKitapEkle.TabIndex = 5;
            // 
            // CBTurEkle
            // 
            this.CBTurEkle.FormattingEnabled = true;
            this.CBTurEkle.Items.AddRange(new object[] {
            "Fantastik",
            "Gerilim",
            "Aksiyon",
            "Psikolojik",
            "Akademik",
            "Bilim-Kurgu",
            "Tarihi"});
            this.CBTurEkle.Location = new System.Drawing.Point(74, 88);
            this.CBTurEkle.Name = "CBTurEkle";
            this.CBTurEkle.Size = new System.Drawing.Size(121, 21);
            this.CBTurEkle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Açıklama =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Türü =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazarı =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı =";
            // 
            // GBKitapDuzenle
            // 
            this.GBKitapDuzenle.Controls.Add(this.BtKitapDuzenle);
            this.GBKitapDuzenle.Controls.Add(this.BtKitapSil);
            this.GBKitapDuzenle.Controls.Add(this.RtbAcikDz);
            this.GBKitapDuzenle.Controls.Add(this.TxYazarDz);
            this.GBKitapDuzenle.Controls.Add(this.TxKitapDz);
            this.GBKitapDuzenle.Controls.Add(this.CBTurDz);
            this.GBKitapDuzenle.Controls.Add(this.label5);
            this.GBKitapDuzenle.Controls.Add(this.label6);
            this.GBKitapDuzenle.Controls.Add(this.label7);
            this.GBKitapDuzenle.Controls.Add(this.label8);
            this.GBKitapDuzenle.Location = new System.Drawing.Point(527, 213);
            this.GBKitapDuzenle.Name = "GBKitapDuzenle";
            this.GBKitapDuzenle.Size = new System.Drawing.Size(255, 217);
            this.GBKitapDuzenle.TabIndex = 2;
            this.GBKitapDuzenle.TabStop = false;
            this.GBKitapDuzenle.Text = "Düzenle & Sil";
            // 
            // BtKitapDuzenle
            // 
            this.BtKitapDuzenle.Location = new System.Drawing.Point(177, 188);
            this.BtKitapDuzenle.Name = "BtKitapDuzenle";
            this.BtKitapDuzenle.Size = new System.Drawing.Size(64, 28);
            this.BtKitapDuzenle.TabIndex = 16;
            this.BtKitapDuzenle.Text = "Düzenle";
            this.BtKitapDuzenle.UseVisualStyleBackColor = true;
            this.BtKitapDuzenle.Click += new System.EventHandler(this.BtKitapDuzenle_Click);
            // 
            // BtKitapSil
            // 
            this.BtKitapSil.Location = new System.Drawing.Point(16, 187);
            this.BtKitapSil.Name = "BtKitapSil";
            this.BtKitapSil.Size = new System.Drawing.Size(64, 28);
            this.BtKitapSil.TabIndex = 8;
            this.BtKitapSil.Text = "Sil";
            this.BtKitapSil.UseVisualStyleBackColor = true;
            this.BtKitapSil.Click += new System.EventHandler(this.BtKitapSil_Click);
            // 
            // RtbAcikDz
            // 
            this.RtbAcikDz.Location = new System.Drawing.Point(74, 129);
            this.RtbAcikDz.Name = "RtbAcikDz";
            this.RtbAcikDz.Size = new System.Drawing.Size(159, 56);
            this.RtbAcikDz.TabIndex = 15;
            this.RtbAcikDz.Text = "";
            // 
            // TxYazarDz
            // 
            this.TxYazarDz.Location = new System.Drawing.Point(74, 59);
            this.TxYazarDz.Name = "TxYazarDz";
            this.TxYazarDz.Size = new System.Drawing.Size(121, 20);
            this.TxYazarDz.TabIndex = 14;
            // 
            // TxKitapDz
            // 
            this.TxKitapDz.Location = new System.Drawing.Point(74, 26);
            this.TxKitapDz.Name = "TxKitapDz";
            this.TxKitapDz.Size = new System.Drawing.Size(121, 20);
            this.TxKitapDz.TabIndex = 13;
            // 
            // CBTurDz
            // 
            this.CBTurDz.FormattingEnabled = true;
            this.CBTurDz.Items.AddRange(new object[] {
            "Fantastik",
            "Gerilim",
            "Aksiyon",
            "Psikolojik",
            "Akademik",
            "Bilim-Kurgu",
            "Tarihi"});
            this.CBTurDz.Location = new System.Drawing.Point(74, 89);
            this.CBTurDz.Name = "CBTurDz";
            this.CBTurDz.Size = new System.Drawing.Size(121, 21);
            this.CBTurDz.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Açıklama =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Türü =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Yazarı =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Kitap Adı =";
            // 
            // FKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(794, 434);
            this.Controls.Add(this.GBKitapDuzenle);
            this.Controls.Add(this.GBKitapEkle);
            this.Controls.Add(this.DGKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FKitaplar";
            this.Text = "FKitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.DGKitaplar)).EndInit();
            this.GBKitapEkle.ResumeLayout(false);
            this.GBKitapEkle.PerformLayout();
            this.GBKitapDuzenle.ResumeLayout(false);
            this.GBKitapDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGKitaplar;
        private System.Windows.Forms.GroupBox GBKitapEkle;
        private System.Windows.Forms.RichTextBox RtbAcikEkle;
        private System.Windows.Forms.TextBox TxYazarEkle;
        private System.Windows.Forms.TextBox TxKitapEkle;
        private System.Windows.Forms.ComboBox CBTurEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBKitapDuzenle;
        private System.Windows.Forms.Button BtKitapSil;
        private System.Windows.Forms.RichTextBox RtbAcikDz;
        private System.Windows.Forms.TextBox TxYazarDz;
        private System.Windows.Forms.TextBox TxKitapDz;
        private System.Windows.Forms.ComboBox CBTurDz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtKitapOlustur;
        private System.Windows.Forms.Button BtKitapDuzenle;
    }
}