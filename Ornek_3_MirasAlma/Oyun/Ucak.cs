using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_3_MirasAlma.Oyun
{
    /// <summary>
    /// Inheritance: Miras alma
    /// Ucak sınıfı Arac sınıfından türetilerek oluşturulmuştur.
    /// </summary>
    public class Ucak:_Arac
    {
        public int KanatAcikligi { get; set; }
        public override void HareketEt(int km)
        {
            Console.WriteLine("Uçak havalandı");
        }
    }
}
