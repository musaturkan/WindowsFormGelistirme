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
    public partial class MasaYonetim : Form
    {
        public MasaYonetim()
        {
            InitializeComponent();
        }

        private void btn_MasaEkle_Click(object sender, EventArgs e)
        {
            DataModel.LokantaContext model = new DataModel.LokantaContext();

            DataModel.Masa yeniMasa = new DataModel.Masa();
            yeniMasa.Ad = tb_MasaAdi.Text;
            yeniMasa.MasaKodu = tb_MasaKodu.Text;
            yeniMasa.KacKisilik = Convert.ToInt32(tb_KacKisilk.Text);
            yeniMasa.EklenmeTarihi = DateTime.Now;

            model.Masa.Add(yeniMasa);

            model.SaveChanges();

            var masaListe = model.Masa.ToList();
            dgv_MasaListe.DataSource = masaListe;
        }

        private void MasaYonetim_Load(object sender, EventArgs e)
        {
            DataModel.LokantaContext model = new DataModel.LokantaContext();
            var masaListe = model.Masa.ToList();

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
                DataModel.LokantaContext model = new DataModel.LokantaContext();

                var silinecekMasa = model.Masa.FirstOrDefault(m => m.Id == masaId);
                //model.Remove<DataModel.Masa>(silinecekMasa);
                if (silinecekMasa != null)
                {
                    model.Masa.Remove(silinecekMasa);
                    model.SaveChanges();
                    dgv_MasaListe.DataSource = model.Masa.ToList();
                }

            }


        }

        private void btn_MasaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_MasaListe.SelectedRows.Count>0)
            {
                var secilenId = Convert.ToInt32(dgv_MasaListe.SelectedRows[0].Cells[0].Value);
                DataModel.LokantaContext model = new DataModel.LokantaContext();
                var guncellenecekMasa=model.Masa.FirstOrDefault(m=>m.Id==secilenId);

                guncellenecekMasa.Ad = tb_MasaAdi.Text;
                guncellenecekMasa.MasaKodu = tb_MasaKodu.Text;
                guncellenecekMasa.KacKisilik = Convert.ToInt32(tb_KacKisilk.Text);
                model.SaveChanges();

                dgv_MasaListe.DataSource=model.Masa.ToList();
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
