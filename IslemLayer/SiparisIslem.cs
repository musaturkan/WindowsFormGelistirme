using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer
{
    public class SiparisIslem
    {
        public void SiparisEkle(VeriKatmani.LokantaVt.Siparis yeniSiparis)
        {
            VeriKatmani.LokantaVt.LokantaContext model = new VeriKatmani.LokantaVt.LokantaContext();
            model.Siparis.Add(yeniSiparis);
            model.SaveChanges();

        }

        public void SiparisEkle(List<VeriKatmani.LokantaVt.Siparis> yeniSiparis)
        {
            VeriKatmani.LokantaVt.LokantaContext model = new VeriKatmani.LokantaVt.LokantaContext();
            model.Siparis.AddRange(yeniSiparis);
            model.SaveChanges();

        }
    }
}
