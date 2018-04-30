namespace Kutuphane_Otomasyon
{
    partial class AnaEkran
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
            this.PLMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTCıkıs = new System.Windows.Forms.Button();
            this.BTKitapAlim = new System.Windows.Forms.Button();
            this.BTKitaplar = new System.Windows.Forms.Button();
            this.BTKisiler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DGBildirim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PLMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBildirim)).BeginInit();
            this.SuspendLayout();
            // 
            // PLMenu
            // 
            this.PLMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PLMenu.Controls.Add(this.pictureBox1);
            this.PLMenu.Controls.Add(this.BTCıkıs);
            this.PLMenu.Controls.Add(this.BTKitapAlim);
            this.PLMenu.Controls.Add(this.BTKitaplar);
            this.PLMenu.Controls.Add(this.BTKisiler);
            this.PLMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLMenu.Location = new System.Drawing.Point(0, 0);
            this.PLMenu.Name = "PLMenu";
            this.PLMenu.Size = new System.Drawing.Size(118, 538);
            this.PLMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kutuphane_Otomasyon.Properties.Resources.folder_library__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTCıkıs
            // 
            this.BTCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTCıkıs.Location = new System.Drawing.Point(12, 434);
            this.BTCıkıs.Name = "BTCıkıs";
            this.BTCıkıs.Size = new System.Drawing.Size(93, 42);
            this.BTCıkıs.TabIndex = 3;
            this.BTCıkıs.Text = "Çıkış";
            this.BTCıkıs.UseVisualStyleBackColor = true;
            this.BTCıkıs.Click += new System.EventHandler(this.BTCıkıs_Click);
            // 
            // BTKitapAlim
            // 
            this.BTKitapAlim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTKitapAlim.Location = new System.Drawing.Point(12, 277);
            this.BTKitapAlim.Name = "BTKitapAlim";
            this.BTKitapAlim.Size = new System.Drawing.Size(93, 42);
            this.BTKitapAlim.TabIndex = 2;
            this.BTKitapAlim.Text = "KitapAlım";
            this.BTKitapAlim.UseVisualStyleBackColor = true;
            this.BTKitapAlim.Click += new System.EventHandler(this.BTKitapAlim_Click);
            // 
            // BTKitaplar
            // 
            this.BTKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTKitaplar.Location = new System.Drawing.Point(12, 204);
            this.BTKitaplar.Name = "BTKitaplar";
            this.BTKitaplar.Size = new System.Drawing.Size(93, 42);
            this.BTKitaplar.TabIndex = 1;
            this.BTKitaplar.Text = "Kitaplar";
            this.BTKitaplar.UseVisualStyleBackColor = true;
            this.BTKitaplar.Click += new System.EventHandler(this.BTKitaplar_Click);
            // 
            // BTKisiler
            // 
            this.BTKisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTKisiler.Location = new System.Drawing.Point(12, 133);
            this.BTKisiler.Name = "BTKisiler";
            this.BTKisiler.Size = new System.Drawing.Size(93, 42);
            this.BTKisiler.TabIndex = 0;
            this.BTKisiler.Text = "Kişiler";
            this.BTKisiler.UseVisualStyleBackColor = true;
            this.BTKisiler.Click += new System.EventHandler(this.BTKisiler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DGBildirim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(118, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 100);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Kutuphane_Otomasyon.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(356, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGBildirim
            // 
            this.DGBildirim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGBildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBildirim.Location = new System.Drawing.Point(0, 3);
            this.DGBildirim.Name = "DGBildirim";
            this.DGBildirim.Size = new System.Drawing.Size(350, 94);
            this.DGBildirim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(356, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PLMenu);
            this.IsMdiContainer = true;
            this.Name = "AnaEkran";
            this.Text = "Kutuphane Otomasyon";
            this.PLMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBildirim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PLMenu;
        private System.Windows.Forms.Button BTCıkıs;
        private System.Windows.Forms.Button BTKitapAlim;
        private System.Windows.Forms.Button BTKitaplar;
        private System.Windows.Forms.Button BTKisiler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGBildirim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

