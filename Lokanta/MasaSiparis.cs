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
            int y_ekseni = 10;
            int x_ekseni = 10;
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
                x_ekseni = 10;
                y_ekseni=y_ekseni+100;
            }
           

            


        }
    }
}
