namespace Lokanta
{
    partial class MasaYonetim
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
            tb_MasaAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tb_MasaKodu = new TextBox();
            label4 = new Label();
            tb_KacKisilk = new TextBox();
            btn_MasaEkle = new Button();
            dgv_MasaListe = new DataGridView();
            label5 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            btn_MasaGuncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_MasaListe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(246, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "Masa Yönetim";
            // 
            // tb_MasaAdi
            // 
            tb_MasaAdi.Location = new Point(193, 116);
            tb_MasaAdi.Name = "tb_MasaAdi";
            tb_MasaAdi.Size = new Size(352, 23);
            tb_MasaAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 124);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Masa Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 167);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Masa Kodu:";
            // 
            // tb_MasaKodu
            // 
            tb_MasaKodu.Location = new Point(193, 159);
            tb_MasaKodu.Name = "tb_MasaKodu";
            tb_MasaKodu.Size = new Size(352, 23);
            tb_MasaKodu.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 209);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 6;
            label4.Text = "Masa Kaç Kişilik";
            // 
            // tb_KacKisilk
            // 
            tb_KacKisilk.Location = new Point(193, 201);
            tb_KacKisilk.Name = "tb_KacKisilk";
            tb_KacKisilk.Size = new Size(352, 23);
            tb_KacKisilk.TabIndex = 5;
            // 
            // btn_MasaEkle
            // 
            btn_MasaEkle.Location = new Point(401, 241);
            btn_MasaEkle.Name = "btn_MasaEkle";
            btn_MasaEkle.Size = new Size(144, 37);
            btn_MasaEkle.TabIndex = 7;
            btn_MasaEkle.Text = "Kaydet";
            btn_MasaEkle.UseVisualStyleBackColor = true;
            btn_MasaEkle.Click += btn_MasaEkle_Click;
            // 
            // dgv_MasaListe
            // 
            dgv_MasaListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MasaListe.Location = new Point(29, 406);
            dgv_MasaListe.Name = "dgv_MasaListe";
            dgv_MasaListe.Size = new Size(708, 240);
            dgv_MasaListe.TabIndex = 8;
            dgv_MasaListe.CellContentClick += dgv_MasaListe_CellContentClick;
            dgv_MasaListe.SelectionChanged += dgv_MasaListe_SelectionChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 378);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 9;
            label5.Text = "Kayıtlı Masalar";
            // 
            // ıconButton1
            // 
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            ıconButton1.IconColor = Color.Red;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton1.Location = new Point(572, 345);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(152, 56);
            ıconButton1.TabIndex = 10;
            ıconButton1.Text = "Seçilen Masayı Sil";
            ıconButton1.TextAlign = ContentAlignment.MiddleRight;
            ıconButton1.UseVisualStyleBackColor = true;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // btn_MasaGuncelle
            // 
            btn_MasaGuncelle.Location = new Point(428, 345);
            btn_MasaGuncelle.Name = "btn_MasaGuncelle";
            btn_MasaGuncelle.Size = new Size(138, 55);
            btn_MasaGuncelle.TabIndex = 11;
            btn_MasaGuncelle.Text = "Güncelle";
            btn_MasaGuncelle.UseVisualStyleBackColor = true;
            btn_MasaGuncelle.Click += btn_MasaGuncelle_Click;
            // 
            // MasaYonetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 670);
            Controls.Add(btn_MasaGuncelle);
            Controls.Add(ıconButton1);
            Controls.Add(label5);
            Controls.Add(dgv_MasaListe);
            Controls.Add(btn_MasaEkle);
            Controls.Add(label4);
            Controls.Add(tb_KacKisilk);
            Controls.Add(label3);
            Controls.Add(tb_MasaKodu);
            Controls.Add(label2);
            Controls.Add(tb_MasaAdi);
            Controls.Add(label1);
            Name = "MasaYonetim";
            Text = "MasaYonetim";
            Load += MasaYonetim_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_MasaListe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_MasaAdi;
        private Label label2;
        private Label label3;
        private TextBox tb_MasaKodu;
        private Label label4;
        private TextBox tb_KacKisilk;
        private Button btn_MasaEkle;
        private DataGridView dgv_MasaListe;
        private Label label5;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Button btn_MasaGuncelle;
    }
}