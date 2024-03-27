using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_MirasAlma_2.Oyun.Muhimmat
{
    public interface IMermi
    {
       
        public void Patlat();
        public Silah.Silah SilahDoldur(Silah.Silah siyap);
        public void MuhimmatSatinAl(int miktar);

    }
}
