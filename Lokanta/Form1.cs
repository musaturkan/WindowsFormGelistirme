using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Automation;
using VeriKatmani.LokantaVt;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Lokanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ibtn_Masa_Click(object sender, EventArgs e)
        {
            MasaYonetim masaYonetim = new MasaYonetim();
            masaYonetim.ShowDialog();
        }

        private void btn_KasaIslemleri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            ///Arka planda kalan forma eriþimin kýsýtlanmasý istenirse yeni formu ShowDialog metodu ile görüntüleriz.
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            Tedarikci a = new Tedarikci();
        }

        private void ýconButton1_Click(object sender, EventArgs e)
        {
            //MasaSiparis siparis = new MasaSiparis();
            Siparis siparis = new Siparis();
            siparis.ShowDialog();
        }

        private void btn_YýllýkRapor_Click(object sender, EventArgs e)
        {
            List<IslemLayer.Models.Urun> urunListesi = new List<IslemLayer.Models.Urun>();
         
            
          

            ///Servisleri paralel task olarak baþlatmak
            ///
            Task servisCagrilari = Task.Factory.StartNew(() =>
            {
                Task servis1 = Task.Factory.StartNew(() =>
                {
                    //birinci servis çaðrýsý
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    urunListesi = api.UrunGetir();
                },TaskCreationOptions.AttachedToParent);
                Task servis2 = Task.Factory.StartNew(() =>
                {
                    //ikinci servis çaðrýsý
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    api.UrunAra("pencil");
                }, TaskCreationOptions.AttachedToParent);
                Task servis3 = Task.Factory.StartNew(() =>
                {
                    //üçüncü servis çaðrýsý
                    IslemLayer.WebApi.TestApi api = new IslemLayer.WebApi.TestApi();
                    IslemLayer.Models.Urun yeni = new IslemLayer.Models.Urun();
                    yeni.price = 2547.75M;
                    yeni.title = "Cep Telefonu";
                    yeni.description = "Aciklama";
                    api.UrunEkle(yeni);
                }, TaskCreationOptions.AttachedToParent);
            });



            servisCagrilari.Wait();

            Form urunListeForm = new Form();
            urunListeForm.Size = new Size(800,800);

            DataGridView urunGrid = new DataGridView();
            urunGrid.Size=new Size(700,500);
            urunGrid.Location = new Point(30, 20);

            urunGrid.DataSource = urunListesi;
            urunListeForm.Controls.Add(urunGrid);
            urunListeForm.ShowDialog();
        }
    }
}
