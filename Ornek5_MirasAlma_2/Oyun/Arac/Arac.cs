using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kullanicilar;

namespace Ornek5_MirasAlma_2.Oyun.Arac
{
    public abstract class Arac
    {
        //protected int abc { get; set; }
        public List<Silah.Silah> SilahList { get; set; }
        public virtual void HareketEt()
        {

        }

        public virtual void AtestEt() 
        {
            foreach (var silah in SilahList)
            {
                silah.AtesEt();
            }
        }

        public User AracKomutani { get; set; }
    }
}
