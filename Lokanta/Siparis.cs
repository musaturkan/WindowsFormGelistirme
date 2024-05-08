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
            foreach (var siradakiMasa in masaListe)
            {
                Button buton = new Button();
                buton.Name="Masa_"+siradakiMasa.Id.ToString();
                buton.Text = siradakiMasa.Ad;
                buton.Location = new Point(x_ekseni, y_ekseni);
                buton.Size = new Size(100, 100);
                buton.BackColor = Color.Orange;
                buton.ForeColor = Color.White;
                buton.Click += btn_masa_click;
                
                this.Controls.Add( buton );

                x_ekseni += 100;
            }

        }

        private void btn_masa_click(object sender, EventArgs e)
        {
            var tiklananButon = sender as Button;
            string tiklananButonName = tiklananButon.Name;
            string secilenMasaId = tiklananButonName.Split("_").LastOrDefault();
            YemekListe yemekListe = new YemekListe();
            yemekListe.ShowDialog();

            ///MessageBox.Show("Seçilan Masa Id:" + secilenMasaId);
            ///Masaya ait id bilgisi elde edildikten sonra sipariş
            ///girişi için burada seçilen id kullanılabilir.
        }
    }
}
