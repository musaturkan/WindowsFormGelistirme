namespace WindowsFormsNetFramework
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_KullaniciYonetim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_KullaniciYonetim
            // 
            this.btn_KullaniciYonetim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_KullaniciYonetim.Location = new System.Drawing.Point(18, 264);
            this.btn_KullaniciYonetim.Name = "btn_KullaniciYonetim";
            this.btn_KullaniciYonetim.Size = new System.Drawing.Size(71, 67);
            this.btn_KullaniciYonetim.TabIndex = 2;
            this.btn_KullaniciYonetim.Text = "Kullanıcı Yönetimi";
            this.btn_KullaniciYonetim.UseVisualStyleBackColor = false;
            this.btn_KullaniciYonetim.Click += new System.EventHandler(this.btn_KullaniciYonetim_Click);
            this.btn_KullaniciYonetim.MouseEnter += new System.EventHandler(this.btn_KullaniciYonetim_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_KullaniciYonetim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Windows Form Kotrolleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_KullaniciYonetim;
    }
}

