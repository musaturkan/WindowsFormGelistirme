using System.Linq.Expressions;

namespace WinFormsNetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///Console.WriteLine("merhaba");
            ///Buradan bir console ekran� nas�l a��labilir?
        }

        private void clb_IlListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(clb_IlListesi.SelectedItem.ToString());
        }

        private void button1_click_Metot1(object sender, EventArgs eventArgs)
        {
            notifyIcon1.Text = "Bildirim ikonu";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///Form a��l�rken yap�lmas� istenen i�lemler formload olay�na yaz�l�r.
            ll_universiteBaglanti.LinkVisited = true;
            lbl_AnaBaslik.BackColor = SystemColors.GrayText;


        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}
