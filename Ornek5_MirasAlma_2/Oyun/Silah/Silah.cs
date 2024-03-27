using Ornek5_MirasAlma_2.Oyun.Muhimmat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_MirasAlma_2.Oyun.Silah
{
    public abstract class Silah
    {
        public int MuhimmatSayisi { get; set; }
        public string Marka { get; set; }
        public int Agirlik { get; set; }
        public IMermi Mermi { get; set; }
        public virtual void AtesEt()
        {
            Console.WriteLine("Silahla ateş edildi");
        }
    }
}
