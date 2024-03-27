using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_MirasAlma_2.Oyun.Muhimmat
{
    public class Kursun : IMermi
    {
        public void MuhimmatSatinAl(int miktar)
        {
            throw new NotImplementedException();
        }

        public void Patlat()
        {
            Console.WriteLine("Kurşun patladı");
        }

        public Silah.Silah SilahDoldur(Silah.Silah siyap)
        {
            throw new NotImplementedException();
        }
    }
}
