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
            MasaSiparis siparis = new MasaSiparis();
            siparis.ShowDialog();
        }

        private void btn_KasaIslemleri_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            ///Arka planda kalan forma eriþimin kýsýtlanmasý istenirse yeni formu ShowDialog metodu ile görüntüleriz.
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataModel.LokantaContext model=new DataModel.LokantaContext();
            var masaListesi = model.Masa.ToList();
        }
    }
}
