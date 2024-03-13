using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavasAraclari
{
    public class Ucak
    {
        int _uretimYili = 0;
        int _yakitMiktari = 0;
        public int UretimYili { get; set; }
        public int YakitMiktari 
        {
            get
            { 
                return _yakitMiktari;
            }

            set
            {
                if (value > 0)
                {
                    _yakitMiktari += value;
                }
            }
        }

        public int MaksimumMenzil
        {
            get
            {
                int menzil = _yakitMiktari * 3;
                return menzil;
            }
        }

        public void UcakHareketEttir(int km)
        {
            YakitAzalt(km * 3);
            
            if (MaksimumMenzil<km)
            {
                Console.WriteLine("Araç {0}km hareket etti", km);
            }
            else
            {
                Console.WriteLine("Araç {0}km hareket etti", MaksimumMenzil);
            }
            
        }

        private void YakitAzalt(int yakit)
        {
            if (yakit>0)
            {
                _yakitMiktari -= yakit;
            }
            if (_yakitMiktari < 0)
            {
                _yakitMiktari = 0;
            }
        }
    }

 
}
