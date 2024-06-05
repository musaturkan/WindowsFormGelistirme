namespace Lokanta
{
    partial class YemekListe
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
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            lb_YemekListe = new ListBox();
            lbl_MasaAd = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(27, 114);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Yemek Listesi";
            // 
            // ıconButton1
            // 
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton1.Location = new Point(252, 96);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(169, 43);
            ıconButton1.TabIndex = 2;
            ıconButton1.Text = "Siparişi Kaydet";
            ıconButton1.TextAlign = ContentAlignment.MiddleRight;
            ıconButton1.UseVisualStyleBackColor = true;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // lb_YemekListe
            // 
            lb_YemekListe.DisplayMember = "Ad";
            lb_YemekListe.FormattingEnabled = true;
            lb_YemekListe.ItemHeight = 15;
            lb_YemekListe.Location = new Point(27, 145);
            lb_YemekListe.Name = "lb_YemekListe";
            lb_YemekListe.SelectionMode = SelectionMode.MultiSimple;
            lb_YemekListe.Size = new Size(394, 169);
            lb_YemekListe.TabIndex = 5;
            lb_YemekListe.ValueMember = "Id";
            // 
            // lbl_MasaAd
            // 
            lbl_MasaAd.AutoSize = true;
            lbl_MasaAd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_MasaAd.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_MasaAd.Location = new Point(27, 21);
            lbl_MasaAd.Name = "lbl_MasaAd";
            lbl_MasaAd.Size = new Size(65, 25);
            lbl_MasaAd.TabIndex = 6;
            lbl_MasaAd.Text = "label2";
            // 
            // YemekListe
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(454, 450);
            Controls.Add(lbl_MasaAd);
            Controls.Add(lb_YemekListe);
            Controls.Add(ıconButton1);
            Controls.Add(label1);
            Name = "YemekListe";
            Text = "YemekListe";
            Load += YemekListe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private DataGridView dgv_YemekListe;
        private ListBox lb_YemekListe;
        public Label lbl_MasaAd;
    }
}