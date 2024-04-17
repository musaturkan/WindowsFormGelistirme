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
            clb_YemekListe = new CheckedListBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Yemek Listesi";
            label1.Click += label1_Click;
            // 
            // clb_YemekListe
            // 
            clb_YemekListe.FormattingEnabled = true;
            clb_YemekListe.Items.AddRange(new object[] { "kebap", "Köfte", "Sebze" });
            clb_YemekListe.Location = new Point(27, 104);
            clb_YemekListe.Name = "clb_YemekListe";
            clb_YemekListe.Size = new Size(258, 292);
            clb_YemekListe.TabIndex = 1;
            // 
            // ıconButton1
            // 
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton1.Location = new Point(116, 55);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(169, 43);
            ıconButton1.TabIndex = 2;
            ıconButton1.Text = "Siparişi Kaydet";
            ıconButton1.TextAlign = ContentAlignment.MiddleRight;
            ıconButton1.UseVisualStyleBackColor = true;
            // 
            // YemekListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(ıconButton1);
            Controls.Add(clb_YemekListe);
            Controls.Add(label1);
            Name = "YemekListe";
            Text = "YemekListe";
            Load += YemekListe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox clb_YemekListe;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}