using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_MirasAlma_2.Oyun.Muhimmat
{
    public class TopMermisi : IMermi
    {
       
        public void MuhimmatSatinAl(int miktar)
        {
            Console.WriteLine("Mühimmat satın alındı");
        }

        public void Patlat()
        {
            Console.WriteLine("Top mermisi patladı");
        }

        public Silah.Silah SilahDoldur(Silah.Silah silah)
        {
            Console.WriteLine("Mühimmat dolduruldu");
            return silah;
        }
    }
}
