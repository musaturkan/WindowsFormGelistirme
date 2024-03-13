using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasAraclari
{
    public class Arac
    {
        string renk;
        private int uretimYili;
        private int yakitMiktari = 1;

        public void YakitYukle(int yakit)
        {
            if(yakit >=0)
            {
                yakitMiktari += yakit;
            }
        }

        public int YakitOku()
        {
            return yakitMiktari;
        }


    }
}
