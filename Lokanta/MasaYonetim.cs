using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriKatmani.LokantaVt;
using IslemLayer;
using IslemLayer.Masa_Islem;
using System.ComponentModel.DataAnnotations;
using IslemLayer.Soyutlama;

namespace Lokanta
{
    public partial class MasaYonetim : Form
    {
        //MasaIslem islem = new MasaIslem();
        IMasa masa_islem = new MasaIslem();
        /// <summary>
        /// Dependency Invenision prensibi ile kullanılan Container mantığı
        /// IoC Conteyner
        /// Fabrika tasarım deseniyle nesne üretimi başka bir katmana alınabilir.
        /// </summary>
        public MasaYonetim()
        {
            InitializeComponent();
        }

        private void btn_MasaEkle_Click(object sender, EventArgs e)
        {
            lbl_masa_ekle_error.Text = "";
            //LokantaContext model = new LokantaContext();

            //Masa yeniMasa = new Masa();
            //yeniMasa.Ad = tb_MasaAdi.Text;
            //yeniMasa.MasaKodu = tb_MasaKodu.Text;
            //yeniMasa.KacKisilik = Convert.ToInt32(tb_KacKisilk.Text);
            //yeniMasa.EklenmeTarihi = DateTime.Now;
            IslemLayer.Models.MasaGuncelle_DTO yeniMasa = new IslemLayer.Models.MasaGuncelle_DTO();
            yeniMasa.KacKisilik = Convert.ToInt32(tb_KacKisilk.Text);
            yeniMasa.MasaKodu = tb_MasaKodu.Text;
            yeniMasa.Ad = tb_MasaAdi.Text;

            ValidationContext validation_context = new ValidationContext(yeniMasa);
            List<ValidationResult> liste = new List<ValidationResult>();
            bool modelDogrulama = Validator.TryValidateObject(yeniMasa, validation_context, liste, true);
            
            if (modelDogrulama==false)
            {
                foreach (var hataMesaj in liste)
                {
                    lbl_masa_ekle_error.Text += hataMesaj.ErrorMessage;
                }
            }
            else
            {
                //IslemLayer.Masa_Islem.MasaIslem mislem = new IslemLayer.Masa_Islem.MasaIslem();            
                masa_islem.MasaEkle(yeniMasa);                 
                var masaListe = masa_islem.MasaListeGetir();
                dgv_MasaListe.DataSource = masaListe;
            }



            //model.Masa.Add(yeniMasa);

            //model.SaveChanges();

            //var masaListe = model.Masa.ToList();
           
        }

        private void MasaYonetim_Load(object sender, EventArgs e)
        {
            //LokantaContext model = new LokantaContext();
            //var masaListe = model.Masa.ToList();

            ///MasaIslem islem = new MasaIslem();
            var masaListe = masa_islem.MasaListeGetir();

            dgv_MasaListe.DataSource = masaListe;

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if (dgv_MasaListe.SelectedRows.Count > 0)
            {
                var secilenMasaId = dgv_MasaListe.SelectedRows[0].Cells[0].Value;
                var hucreSecim = dgv_MasaListe.SelectedCells;
                var sutunSecim = dgv_MasaListe.SelectedColumns;

                int masaId = Convert.ToInt32(secilenMasaId);
                //MasaIslem islem = new MasaIslem();
                masa_islem.MasaSil(masaId);
                dgv_MasaListe.DataSource= masa_islem.MasaListeGetir();

                //LokantaContext model = new LokantaContext();

                //var silinecekMasa = model.Masa.FirstOrDefault(m => m.Id == masaId);
                //model.Remove<DataModel.Masa>(silinecekMasa);
                //if (silinecekMasa != null)
                //{
                //    //model.Masa.Remove(silinecekMasa);
                //    //model.SaveChanges();
                //    dgv_MasaListe.DataSource = model.Masa.ToList();
                //}

            }


        }

        private void btn_MasaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_MasaListe.SelectedRows.Count>0)
            {
                var secilenId = Convert.ToInt32(dgv_MasaListe.SelectedRows[0].Cells[0].Value);
                //MasaIslem masaIslem = new MasaIslem();
                IslemLayer.Models.MasaGuncelle_DTO masa = new IslemLayer.Models.MasaGuncelle_DTO();
                masa.Id = secilenId;
                masa.MasaKodu = tb_MasaKodu.Text;
                masa.Ad= tb_MasaAdi.Text;
                masa.KacKisilik= Convert.ToInt32(tb_KacKisilk.Text);
                masa_islem.MasaGuncelle(masa);

                //LokantaContext model = new LokantaContext();
                //var guncellenecekMasa=model.Masa.FirstOrDefault(m=>m.Id==secilenId);

                //guncellenecekMasa.Ad = tb_MasaAdi.Text;
                //guncellenecekMasa.MasaKodu = tb_MasaKodu.Text;
                //guncellenecekMasa.KacKisilik = Convert.ToInt32(tb_KacKisilk.Text);
                //model.SaveChanges();

                dgv_MasaListe.DataSource = masa_islem.MasaListeGetir();
            }
            

        }

        private void dgv_MasaListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_MasaListe.SelectedRows.Count>0)
            {
                tb_MasaAdi.Text = dgv_MasaListe.SelectedRows[0].Cells[1].Value.ToString();
                tb_MasaKodu.Text = dgv_MasaListe.SelectedRows[0].Cells[2].Value.ToString();
                tb_KacKisilk.Text = dgv_MasaListe.SelectedRows[0].Cells[3].Value.ToString();

            }
        }

        private void dgv_MasaListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
