using VeriKatmani.LokantaVt;

namespace Lokanta
{
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        private void Siparis_Load(object sender, EventArgs e)
        {
            LokantaContext model=new LokantaContext();
            var masaListe = model.Masa.ToList();

            int x_ekseni=100,y_ekseni=100;
            int sayac = 0;
            foreach (var siradakiMasa in masaListe)
            {
                if (sayac>=5)
                {
                    sayac = 0;
                    y_ekseni += 100;
                    x_ekseni = 100;
                }
                Button buton = new Button();
                buton.Name="Masa_"+siradakiMasa.Id.ToString();
                buton.Text = siradakiMasa.Ad;
                buton.Location = new Point(x_ekseni, y_ekseni);
                buton.Size = new Size(100, 100);
                buton.BackColor = Color.Orange;
                buton.ForeColor = Color.White;
                buton.Click += btn_masa_click;
                
                this.Controls.Add( buton );
                sayac++;
                x_ekseni += 100;
            }

        }

        private void btn_masa_click(object sender, EventArgs e)
        {
            var tiklananButon = sender as Button;
            string tiklananButonName = tiklananButon.Name;
            string secilenMasaId = tiklananButonName.Split("_").LastOrDefault();
            VeriKatmani.LokantaVt.LokantaContext model = new LokantaContext();
           
            YemekListe yemekListe = new YemekListe();
            
            yemekListe.MasaId=Convert.ToInt32(secilenMasaId);
            
            var masaSiparisListe = model.Siparis.Where(s => s.MasaId == yemekListe.MasaId);
            DataGridView dgv_Siparis = new DataGridView();
            dgv_Siparis.DataSource= masaSiparisListe.Select(s => new {s.Yemek.Ad,Masa = s.Masa.Ad,s.Yemek.Fiyat,s.Tarih}).ToList();
            dgv_Siparis.Location=new Point(30,400);
            dgv_Siparis.Size = new Size(400, 200);
            yemekListe.Controls.Add(dgv_Siparis);/**/
            yemekListe.ShowDialog();
            ///MessageBox.Show("Seçilan Masa Id:" + secilenMasaId);
            ///Masaya ait id bilgisi elde edildikten sonra sipariş
            ///girişi için burada seçilen id kullanılabilir.
        }
    }
}
