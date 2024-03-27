using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3_MirasAlma.Oyun
{
    public abstract class _Arac
    {
        int _yakitMiktari = 0;
        public string Marka { get; set; }
        public int YakitMiktari { get; set; }
        public int UretimYili { get; set; }
        public virtual void HareketEt(int km)
        {
            Console.WriteLine("Araç hareket etti");
        }

        public virtual void MotorCalistir()
        {

        }

        public virtual void Durdur()
        {

        }
    }
}
