using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1;

    public class TemelKavram
    {

        /// <summary>
        /// toplama işlemi yapar
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>tam sayı döndürür</returns>
        public static int Topla(int a, int b)
        {
            Console.WriteLine("Metot parametresi olarak gelen Değerler:");
            Console.WriteLine("a parametresi değeri:{0}", a);
            Console.WriteLine("b parametresinin değeri:{0}", b);

            return a + b;
        }
    }

