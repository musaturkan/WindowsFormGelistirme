using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5_MirasAlma_2.Oyun.Silah
{
    public class Tabanca:Silah
    {
        public Tabanca()
        {
            Marka = "Tanimsiz";
            Agirlik = 1;
            MuhimmatSayisi = 10;
        }

        public Tabanca(int agirlik, int muhimmatSayisi,string marka)
        {
            Marka = marka;
            Agirlik = agirlik;
            MuhimmatSayisi= muhimmatSayisi;
        }



        ///Nesne bellekten silinirken yapılması istenenler varsa buraya yazılır
        ///
        public void Deconstruct()
        {
            Agirlik = 0;
        }
    }
}
