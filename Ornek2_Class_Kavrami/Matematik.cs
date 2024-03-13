using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2_Class_Kavrami
{
    public class Matematik
    {
        /// <summary>
        /// Statik metotlar sınıf ismi ile doğrudan ulaşılabilen metotlardır.
        /// Bir metoda nesne üzerinden değil de sınıf ismi ile erişmek istenirse
        /// metot static anahtar kelimesi  ile işaretlenir
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Topla(int a,int b)
        {
            return a + b;
        }
    }
}
