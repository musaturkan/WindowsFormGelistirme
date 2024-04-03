using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta
{
    public partial class MasaSiparis : Form
    {
        public MasaSiparis()
        {
            InitializeComponent();
        }

        private void btn_MasaSiparis(object sender, EventArgs e)
        {
            var tiklananButon = sender as Button;
            var secilenMasaId = tiklananButon.Name.Split("_").Last();

            MessageBox.Show("Seçilen Masa Id: " + secilenMasaId + "numaralı masa. ");
        }

        private void MasaSiparis_Load(object sender, EventArgs e)
        {
            int y_ekseni = 100;
            int x_ekseni = 100;

            Label formBaslik=new Label();
            formBaslik.Location = new Point(150,10);
            formBaslik.Text = "Masa Sipariş Alma Formu";
            formBaslik.Size = new Size(400, 50);
            formBaslik.ForeColor = Color.DarkRed;
            formBaslik.BackColor = Color.Azure;
            formBaslik.Font = new Font("Arial",18); 
            this.Controls.Add(formBaslik);


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Name = "Ahmet_gel_" + i.ToString() + j.ToString() ;
                    btn.Text = "Ahmet Gel";
                    btn.BackColor = Color.DarkRed;
                    btn.ForeColor = Color.White;
                    btn.Location = new Point(x_ekseni, y_ekseni);
                    btn.Size = new Size(100, 100);
                    btn.Click += btn_MasaSiparis;                          
                    this.Controls.Add(btn);
                    x_ekseni=x_ekseni+100;
                }
                x_ekseni = 100;
                y_ekseni=y_ekseni+100;
            }

            this.Size = new Size(1024, 700);

        }
    }
}
