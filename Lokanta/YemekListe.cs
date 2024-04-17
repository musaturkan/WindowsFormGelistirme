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
            DataModel.LokantaContext model = new DataModel.LokantaContext();
            var yemekAdListe = model.Yemek.Select(s => s.Ad).ToList();

            ///clb_YemekListe.DataContext = yemekAdListe;

            foreach (var yemek in yemekAdListe)
            {
                clb_YemekListe.Items.Add(yemek);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
