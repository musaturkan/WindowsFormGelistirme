using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriKatmani.LokantaVt;

namespace IslemLayer.Yemek_Islem
{
    public class YemekIslem
    {
        public List<Yemek> YemekListe()
        {
            LokantaContext model = new LokantaContext();
            var yemekListe = model.Yemek.ToList();
            return yemekListe;
        }
    }
}
