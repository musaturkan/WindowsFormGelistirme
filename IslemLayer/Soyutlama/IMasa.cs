using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.Soyutlama
{
    public interface IMasa
    {
        void MasaSil(int Id);
        List<Models.Masa_Poco> MasaListeGetir();
        void MasaEkle(Models.MasaGuncelle_DTO yeniMasa);
        void MasaGuncelle(Models.MasaGuncelle_DTO yeniMasa);
    }
}
