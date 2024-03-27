using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4_Generic_Kavramı
{
    public class Hesaplama
    {
        public int Topla(int x, int y)
        {
            return x + y;
        }

        ///Generic Motot Tanımlama
        ///
        public T Toplama<T>(T x, T y)
        {
            return x;
        }



    }
}
