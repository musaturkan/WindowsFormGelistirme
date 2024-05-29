using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemLayer.Soyutlama
{
    public interface IMasaFabrika
    {
        public IMasa MasaOlustur(MasaTipi masaTipi);
        public IMasa MasaOlusturGeneric<T>();
        public IMasa MasaOlusturGeneric2<T>();
    }
}
