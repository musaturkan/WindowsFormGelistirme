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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ///Buradaki veri tabanı işlemlerinin her biri paralel Task olarak yapılabilir
            VeriKatmani.LokantaVt.LokantaContext model = new VeriKatmani.LokantaVt.LokantaContext();

            lbl_TopamSiparisSayi.Text = model.Siparis.Count().ToString();            

            lbl_ToplamCiro.Text = model.Siparis.Sum(s => s.Yemek.Fiyat).ToString();

            DateTime bugun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            lbl_GunlukCiro.Text = model.Siparis.Where(s => s.Tarih.Value >= bugun
                                                        && s.Tarih <= bugun.AddDays(1)).Sum(p=>p.Yemek.Fiyat).ToString();

            lbl_GunlukSiparisSayisi.Text = model.Siparis.Where(s => s.Tarih >= bugun 
                                                                    && s.Tarih<=bugun.AddDays(1)).Count().ToString() ;
        }
    }
}
