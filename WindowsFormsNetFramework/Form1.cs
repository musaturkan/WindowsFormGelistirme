using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_KullaniciYonetim_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Butonun üzerine gelindi");
        }

        private void btn_KullaniciYonetim_Click(object sender, EventArgs e)
        {
            ///Buraaya click olayında yapılması istenen işlemler yazılır
            ///
            //this.BackColor = SystemColors.ControlDark;
            if (btn_KullaniciYonetim.BackColor==SystemColors.ControlDark)
            {
                btn_KullaniciYonetim.BackColor= SystemColors.Control;
            }
            else
            {
                btn_KullaniciYonetim.BackColor = SystemColors.ControlDark;
            }
           

        }
    }
}
