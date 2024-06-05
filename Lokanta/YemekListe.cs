using IslemLayer;
using IslemLayer.Masa_Islem;
using IslemLayer.Yemek_Islem;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
        SiparisIslem islem = new SiparisIslem();
        public int MasaId { get; set; }
        private void YemekListe_Load(object sender, EventArgs e)
        {
            //LokantaContext model = new LokantaContext();
            //var yemekAdListe = model.Yemek.Select(s => s.Ad).ToList();
            YemekIslem islem = new YemekIslem();
            MasaIslem masaIslem= new MasaIslem();
            var masa = masaIslem.MasaListeGetir().FirstOrDefault(m => m.Id == MasaId);
            lbl_MasaAd.Text = masa.Ad + " Masası İçin Sipariş Alınıyor";
            var yemekListe = islem.YemekListe();
            //cb_YemekListe.DataSource = yemekListe;
            //dgv_YemekListe.DataSource = yemekListe;
            lb_YemekListe.DataSource= yemekListe;    
            ///clb_YemekListe.DataContext = yemekAdListe;

            //foreach (var yemek in yemekListe)
            //{
            //    //clb_YemekListe.Items.Add(yemek.Ad);
            //}
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            //var secilenYemekListe = clb_YemekListe.CheckedItems;

            VeriKatmani.LokantaVt.LokantaContext model = new LokantaContext();

            //foreach (var secilenKayit in secilenYemekListe)
            //{
            //    VeriKatmani.LokantaVt.Siparis siparis = new VeriKatmani.LokantaVt.Siparis();
            //    siparis.MasaId = MasaId;
            //    siparis.Tarih = DateTime.Now;
            //    ///yemekId alanı doldurulacak
            //    var yemek = model.Yemek.FirstOrDefault(p => p.Ad == secilenKayit);
            //    siparis.YemekId = yemek.Id;
            //    model.Siparis.Add(siparis);
            //}
            //model.SaveChanges();
            var secilenYemekListe = lb_YemekListe.SelectedItems;
            List<VeriKatmani.LokantaVt.Siparis> liste = new List<VeriKatmani.LokantaVt.Siparis>();
            foreach (Yemek secilenKayit in secilenYemekListe)
            {
                VeriKatmani.LokantaVt.Siparis siparis = new VeriKatmani.LokantaVt.Siparis();
                siparis.MasaId = MasaId;
                siparis.Tarih = DateTime.Now;
                siparis.YemekId = secilenKayit.Id;
                ///yemekId alanı doldurulacak
                //var yemek = model.Yemek.FirstOrDefault(p => p.Ad == secilenKayit);
                //siparis.YemekId = yemek.Id;
                liste.Add(siparis);
            }
            
            islem.SiparisEkle(liste);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
