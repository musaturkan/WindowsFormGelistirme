using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Numerics;
using System.Collections;


namespace Ornek1
{  
    public class Program
    {
        static int a = 15;
        float b = 12;
        double c = 15.2;
        string isim = "merhaba Ahmet";
        string d = "55";
        char e ='A';
        bool f = true;  //false
        object o = 23;
        byte g;

        private static void Main(string[] args)
        {
            int sayi;
            string kullaniciAd;
            sayi = 12;
            var g = "merhaba";
            a = 11;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Selamunaleyküm Millet");
            Console.WriteLine(sayi);
            Console.WriteLine("sayi isimli değişkenin değeri:{0} a isimli değiken:{1}", sayi,a);
            int not = 0;
            kullaniciAd = Console.ReadLine();

            Console.WriteLine("Merhaba {0}", kullaniciAd);

            Console.WriteLine("Sayısal bir not giriniz");
            ///Tip Dönüştürme işlemleri
            //string girilenNot = Console.ReadLine();
            not = Convert.ToInt32(Console.ReadLine());

            

            ///Temel Programlama Yapıları
            ///
         
            ///Karar Yapıları
            if(a>25 && (kullaniciAd == "Muhsin" || kullaniciAd=="Ahmet"))
            {
                ///şart doğrusya çalışacak komutlar
            }

            switch (kullaniciAd)
            {
                case "Musa":Console.WriteLine();break;
                case "Ahmet":Console.WriteLine(sayi); break;
                default: Console.WriteLine();break;
            }

            if (sayi>25)
            {

            }
            else if (sayi > 45)
            {

            }
            else if (sayi>60)
            {

            }
            else
            {

            }


            ///Diziler
            string[] dizi = { "Ali", "Ayşe", "Hasan", "Osman" };

            int[] sayilar = { 23, 4, 5, 6, 67 };
            int[] sayilar2 = new int[5];
                      

            dizi[2] = "Elif";
            dizi[3] = "Kerem";

            Console.WriteLine(sayilar[2]);


            ///Generic liste tanımı
            List<int> liste = new List<int>();

            liste.Add(45);
            liste.Add(98);
            
            ///Döngüler
            //for döngüsü
            for(int i = 0;i<4;i++) 
            {
                Console.WriteLine(dizi[i]);
                //break;
                //continue;
            }
            
            //while döngüsü
            int sayac = 0;            
            while(sayac<4)
            {
                Console.WriteLine(dizi[sayac]);
                sayac=sayac+1;

                //break;
                //continue;

                //sayac += 1;
                //sayac += 3;
                //sayac++;
            }

            do
            {
                Console.WriteLine();
            }
            while (sayac > 4);


            ///foreach döngüsü
            ///Var olan bir dizi elemanlarına sırayla erişmemmizi sağlar. 
            ///Her çevrimde sıradaki dizi elemanını döngü değişkeni olarak ele alabiliriz.

            foreach (var siradakiEleman in liste)
            {
                int hesap = siradakiEleman * 3;

                Console.WriteLine(hesap);
            }


            ///Metot Çağırma
            ///

            Selam();
            Selam();

            int toplamSonuc = 0;
                
            toplamSonuc =  TemelKavram.Topla(not, a);


        }


        ////Metot Kavramı
        ///Metot Oluşturma;
        ///Geri dönüş tipi
        ///Argüman Parantezleri
        ///Metod Adı
        //Argüman Tipi
        
        ///Bu iki tamsayıyı toplayan mettot olarak kullanılır.
        ///Geri dönüş tipi tam sayıdır
        private static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        /// <summary>
        /// İki float sayiyi toplar ve float döndürür.
        /// </summary>
        /// <param name="sayi1">toplanacak float türünden sayıdır</param>
        /// <param name="sayi2">toplanacak ikinci sayıdır</param>
        /// <returns></returns>
        private static float Topla(float sayi1, float sayi2)
        {
            float sonuc;
            sonuc = sayi1+sayi2;

            //return Convert.ToInt32(sonuc);
            return sonuc;
        }

        /// <summary>
        /// Ekrana selam yazdıran parametresiz metottur.
        /// </summary>
        private static void Selam()
        {
            Console.WriteLine("Selamunaleyküm Millet");
        }

    }

}
