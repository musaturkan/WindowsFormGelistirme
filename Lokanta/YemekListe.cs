using IslemLayer.Yemek_Islem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriKatmani.LokantaVt;

namespace Lokanta
{
    public partial class YemekListe : Form
    {
        public YemekListe()
        {
            InitializeComponent();
        }

        private void YemekListe_Load(object sender, EventArgs e)
        {
            //LokantaContext model = new LokantaContext();
            //var yemekAdListe = model.Yemek.Select(s => s.Ad).ToList();
            YemekIslem islem = new YemekIslem();
            var yemekListe = islem.YemekListe();

            ///clb_YemekListe.DataContext = yemekAdListe;

            foreach (var yemek in yemekListe)
            {
                clb_YemekListe.Items.Add(yemek.Ad);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
