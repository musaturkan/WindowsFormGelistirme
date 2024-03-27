using Ornek5_MirasAlma_2.Oyun.Arac;
using Ornek5_MirasAlma_2.Oyun.Silah;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanicilar
{
    public abstract class User
    {
        public string Adi { get; set; }
        public Silah  Silah { get; set; }          
        public List<Silah> SilahListe { get; set; }
        public Arac Arac { get; set; }
    }
}
