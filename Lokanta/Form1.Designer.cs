namespace Lokanta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_AnaEkran = new Panel();
            ibtn_Masa = new FontAwesome.Sharp.IconButton();
            btn_YıllıkRapor = new Button();
            btn_PersonelRapor = new Button();
            btn_DepoRapor = new Button();
            btn_SiparisRapor = new Button();
            btn_KasaIslemleri = new Button();
            btn_Musteri = new Button();
            btn_Mutfak = new Button();
            btn_PaketServis = new Button();
            btn_Rezervasyon = new Button();
            pnl_AnaEkran.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_AnaEkran
            // 
            pnl_AnaEkran.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_AnaEkran.Controls.Add(ibtn_Masa);
            pnl_AnaEkran.Controls.Add(btn_YıllıkRapor);
            pnl_AnaEkran.Controls.Add(btn_PersonelRapor);
            pnl_AnaEkran.Controls.Add(btn_DepoRapor);
            pnl_AnaEkran.Controls.Add(btn_SiparisRapor);
            pnl_AnaEkran.Controls.Add(btn_KasaIslemleri);
            pnl_AnaEkran.Controls.Add(btn_Musteri);
            pnl_AnaEkran.Controls.Add(btn_Mutfak);
            pnl_AnaEkran.Controls.Add(btn_PaketServis);
            pnl_AnaEkran.Controls.Add(btn_Rezervasyon);
            pnl_AnaEkran.Location = new Point(94, 130);
            pnl_AnaEkran.Name = "pnl_AnaEkran";
            pnl_AnaEkran.Size = new Size(487, 361);
            pnl_AnaEkran.TabIndex = 0;
            // 
            // ibtn_Masa
            // 
            ibtn_Masa.BackColor = Color.DarkGreen;
            ibtn_Masa.Font = new Font("Segoe UI", 18F);
            ibtn_Masa.ForeColor = Color.White;
            ibtn_Masa.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
            ibtn_Masa.IconColor = Color.FromArgb(255, 128, 0);
            ibtn_Masa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtn_Masa.IconSize = 75;
            ibtn_Masa.Location = new Point(0, 3);
            ibtn_Masa.Name = "ibtn_Masa";
            ibtn_Masa.Size = new Size(247, 123);
            ibtn_Masa.TabIndex = 1;
            ibtn_Masa.Text = "Masa";
            ibtn_Masa.TextAlign = ContentAlignment.MiddleRight;
            ibtn_Masa.UseVisualStyleBackColor = false;
            ibtn_Masa.Click += ibtn_Masa_Click;
            // 
            // btn_YıllıkRapor
            // 
            btn_YıllıkRapor.Font = new Font("Segoe UI", 12F);
            btn_YıllıkRapor.Location = new Point(368, 253);
            btn_YıllıkRapor.Name = "btn_YıllıkRapor";
            btn_YıllıkRapor.Size = new Size(113, 100);
            btn_YıllıkRapor.TabIndex = 9;
            btn_YıllıkRapor.Text = "Yıllık Rapor";
            btn_YıllıkRapor.UseVisualStyleBackColor = true;
            // 
            // btn_PersonelRapor
            // 
            btn_PersonelRapor.Font = new Font("Segoe UI", 12F);
            btn_PersonelRapor.Location = new Point(249, 253);
            btn_PersonelRapor.Name = "btn_PersonelRapor";
            btn_PersonelRapor.Size = new Size(113, 100);
            btn_PersonelRapor.TabIndex = 8;
            btn_PersonelRapor.Text = "Personel Rapor";
            btn_PersonelRapor.UseVisualStyleBackColor = true;
            // 
            // btn_DepoRapor
            // 
            btn_DepoRapor.Font = new Font("Segoe UI", 12F);
            btn_DepoRapor.Location = new Point(128, 253);
            btn_DepoRapor.Name = "btn_DepoRapor";
            btn_DepoRapor.Size = new Size(113, 100);
            btn_DepoRapor.TabIndex = 7;
            btn_DepoRapor.Text = "Depo Rapor";
            btn_DepoRapor.UseVisualStyleBackColor = true;
            // 
            // btn_SiparisRapor
            // 
            btn_SiparisRapor.Font = new Font("Segoe UI", 12F);
            btn_SiparisRapor.Location = new Point(3, 253);
            btn_SiparisRapor.Name = "btn_SiparisRapor";
            btn_SiparisRapor.Size = new Size(117, 100);
            btn_SiparisRapor.TabIndex = 6;
            btn_SiparisRapor.Text = "Siparis Rapor";
            btn_SiparisRapor.UseVisualStyleBackColor = true;
            // 
            // btn_KasaIslemleri
            // 
            btn_KasaIslemleri.BackColor = Color.DarkOliveGreen;
            btn_KasaIslemleri.Font = new Font("Segoe UI", 14F);
            btn_KasaIslemleri.ForeColor = Color.White;
            btn_KasaIslemleri.Location = new Point(123, 127);
            btn_KasaIslemleri.Name = "btn_KasaIslemleri";
            btn_KasaIslemleri.Size = new Size(124, 122);
            btn_KasaIslemleri.TabIndex = 5;
            btn_KasaIslemleri.Text = "Kasa İşlemleri";
            btn_KasaIslemleri.UseVisualStyleBackColor = false;
            btn_KasaIslemleri.Click += btn_KasaIslemleri_Click;
            // 
            // btn_Musteri
            // 
            btn_Musteri.BackColor = Color.OrangeRed;
            btn_Musteri.Font = new Font("Segoe UI", 14F);
            btn_Musteri.ForeColor = Color.White;
            btn_Musteri.Location = new Point(3, 126);
            btn_Musteri.Name = "btn_Musteri";
            btn_Musteri.Size = new Size(119, 122);
            btn_Musteri.TabIndex = 4;
            btn_Musteri.Text = "Müşteri";
            btn_Musteri.UseVisualStyleBackColor = false;
            // 
            // btn_Mutfak
            // 
            btn_Mutfak.BackColor = Color.DarkGreen;
            btn_Mutfak.Font = new Font("Segoe UI", 24F);
            btn_Mutfak.ForeColor = SystemColors.ControlLightLight;
            btn_Mutfak.Location = new Point(241, 126);
            btn_Mutfak.Name = "btn_Mutfak";
            btn_Mutfak.Size = new Size(246, 122);
            btn_Mutfak.TabIndex = 3;
            btn_Mutfak.Text = "Mutfak";
            btn_Mutfak.UseVisualStyleBackColor = false;
            // 
            // btn_PaketServis
            // 
            btn_PaketServis.BackColor = Color.DarkOliveGreen;
            btn_PaketServis.Font = new Font("Segoe UI", 24F);
            btn_PaketServis.ForeColor = Color.White;
            btn_PaketServis.Location = new Point(363, 4);
            btn_PaketServis.Name = "btn_PaketServis";
            btn_PaketServis.Size = new Size(124, 122);
            btn_PaketServis.TabIndex = 2;
            btn_PaketServis.Text = "Paket Servis";
            btn_PaketServis.UseVisualStyleBackColor = false;
            // 
            // btn_Rezervasyon
            // 
            btn_Rezervasyon.BackColor = Color.OrangeRed;
            btn_Rezervasyon.Font = new Font("Segoe UI", 12F);
            btn_Rezervasyon.ForeColor = Color.White;
            btn_Rezervasyon.Location = new Point(245, 4);
            btn_Rezervasyon.Name = "btn_Rezervasyon";
            btn_Rezervasyon.Size = new Size(119, 122);
            btn_Rezervasyon.TabIndex = 1;
            btn_Rezervasyon.Text = "Rezervasyon";
            btn_Rezervasyon.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 619);
            Controls.Add(pnl_AnaEkran);
            Name = "Form1";
            Text = "Form1";
            pnl_AnaEkran.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_AnaEkran;
        private Button btn_PaketServis;
        private Button btn_Rezervasyon;
        private Button btn_YıllıkRapor;
        private Button btn_PersonelRapor;
        private Button btn_DepoRapor;
        private Button btn_SiparisRapor;
        private Button btn_KasaIslemleri;
        private Button btn_Musteri;
        private Button btn_Mutfak;
        private FontAwesome.Sharp.IconButton ibtn_Masa;
       
    }
}
